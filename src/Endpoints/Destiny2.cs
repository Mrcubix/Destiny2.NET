using System.Security.Authentication;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using API.Entities.Config;
using API.Entities.HistoricalStats;
using API.Entities.Request.User;
using API.Entities.Responses;
using API.Entities.Responses.Base;
using API.Entities.User;
using API.Enums;

namespace API.Endpoints
{
    public class Destiny2
    {
        private HttpClient client = new();
        public static string BaseUrl = "https://www.bungie.net/Platform";
        public static InvalidCredentialException InvalidAPIKeyException { get; } = new("The API Key provided is invalid");
        public static HttpRequestException requestProcessingErrorResponse { get; } = new("There was an issue processing the request.");
        public JsonSerializerOptions SerializerOptions { get; set; }
        public APISettings settings { get; }

        public Destiny2(APISettings settings)
        {
            this.settings = settings;

            if (string.IsNullOrEmpty(settings.Key))
            {
                Console.WriteLine("API Key is not set, please set it in the settings.");
            }
            else
            {
                client.DefaultRequestHeaders.Add("x-api-key", settings.Key);
            }

            SerializerOptions = new()
            {
                PropertyNameCaseInsensitive = true,
                NumberHandling = JsonNumberHandling.AllowReadingFromString
            };

            settings.OnKeyChanged += (sender, key) =>
            {
                client.DefaultRequestHeaders.Remove("x-api-key");
                client.DefaultRequestHeaders.Add("x-api-key", key);
            };
        }

        public async Task<DestinyManifest> GetDestinyManifest()
        {
            string serializedResponse = await SendRequest("GET", new Uri($"{BaseUrl}/Destiny2/Manifest/"));

            if (serializedResponse == null)
                throw requestProcessingErrorResponse;

            return JsonSerializer.Deserialize<APIResponse<DestinyManifest>>(serializedResponse, SerializerOptions).Response;
        }

        public async Task<List<UserInfoCard>> SearchDestinyPlayerByBungieName(string name, short tag)
        {
            if (string.IsNullOrEmpty(settings.Key))
                throw InvalidAPIKeyException;

            ExactSearchRequest body = new();
            body.displayName = name;
            body.displayNameCode = tag;

            string serializedResponse = await SendRequest("POST", new($"{BaseUrl}/Destiny2/SearchDestinyPlayerByBungieName/all"), body);

            if (serializedResponse == null)
                throw requestProcessingErrorResponse;

            return JsonSerializer.Deserialize<APIResponse<List<UserInfoCard>>>(serializedResponse, SerializerOptions).Response;
        }

        public async Task<DestinyProfileResponse> GetProfile(int type, long id, DestinyComponentType component)
        {
            if (string.IsNullOrEmpty(settings.Key))
                throw InvalidAPIKeyException;

            string serializedResponse = await SendRequest("GET", new Uri($"{BaseUrl}/Destiny2/{type}/Profile/{id}/?components={component}"));

            if (serializedResponse == null)
                throw requestProcessingErrorResponse;

            return JsonSerializer.Deserialize<APIResponse<DestinyProfileResponse>>(serializedResponse, SerializerOptions).Response;
        }

        public async Task<DestinyProfileResponse> GetProfile(int type, long id, IEnumerable<DestinyComponentType> components)
        {
            if (string.IsNullOrEmpty(settings.Key))
                throw InvalidAPIKeyException;

            string serializedComponents = "";

            foreach (DestinyComponentType component in components)
            {
                serializedComponents += serializedComponents == "" ? $"{component}" : $", {component}";
            }

            string serializedResponse = await SendRequest("GET", new Uri($"{BaseUrl}/Destiny2/{type}/Profile/{id}/?components={serializedComponents}"));

            if (serializedResponse == null)
                throw requestProcessingErrorResponse;

            return JsonSerializer.Deserialize<APIResponse<DestinyProfileResponse>>(serializedResponse, SerializerOptions).Response;
        }

        public async Task<DestinyCharacterResponse> GetCharacter(int type, long id, long characterId, DestinyComponentType component)
        {
            if (string.IsNullOrEmpty(settings.Key))
                throw InvalidAPIKeyException;

            string serializedResponse = await SendRequest("GET", new Uri($"{BaseUrl}/Destiny2/{type}/Profile/{id}/Character/{characterId}/?components={component}"));

            if (serializedResponse == null)
                throw requestProcessingErrorResponse;

            return JsonSerializer.Deserialize<APIResponse<DestinyCharacterResponse>>(serializedResponse, SerializerOptions).Response;
        }

        public async Task<DestinyCharacterResponse> GetCharacter(int type, long id, long characterId, IEnumerable<DestinyComponentType> components)
        {
            if (string.IsNullOrEmpty(settings.Key))
                throw InvalidAPIKeyException;

            string serializedComponents = "";

            foreach (DestinyComponentType component in components)
            {
                serializedComponents += $", {component}";
            }

            string serializedResponse = await SendRequest("GET", new Uri($"{BaseUrl}/Destiny2/{type}/Profile/{id}/Character/{characterId}/?components={serializedComponents}"));

            if (serializedResponse == null)
                throw requestProcessingErrorResponse;

            return JsonSerializer.Deserialize<APIResponse<DestinyCharacterResponse>>(serializedResponse, SerializerOptions).Response;
        }

        public async Task<DestinyHistoricalStatsPeriodGroup[]> GetActivityHistory(int type, long id, long characterId, int count, int mode, int page)
        {
            string serializedResponse = await SendRequest("GET", new Uri($"{BaseUrl}/Destiny2/{type}/Account/{id}/Character/{characterId}/Stats/Activities/?count={count}&mode={mode}&page={page}"));

            if (serializedResponse == null)
            {
                Console.WriteLine("There was an issue processing the request.");
                Environment.Exit(11);
            }

            return JsonSerializer.Deserialize<APIResponse<DestinyActivityHistoryResults>>(serializedResponse, SerializerOptions).Response.Activities;
        }

        public async Task<string> SendRequest(string method, Uri url, object body = null)
        {
            HttpResponseMessage response = null;
            HttpRequestMessage request = null;

            short retries = 0;

            while (retries++ < settings.MaxRetries - 1)
            {
                try
                {
                    if (method.ToLower() == "post")
                    {
                        if (body != null)
                        {
                            request = new();
                            request.Content = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");
                            request.Method = new("POST");
                            request.RequestUri = url;
                        }

                        response = await client.SendAsync(request);
                    }
                    else if (method.ToLower() == "get")
                    {
                        response = await client.GetAsync(url);
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("An exception occured while processing the request, This may be due because you're not connected to the internet.");
                }

                if (response != null && response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    await HandleError(response);

                    Console.WriteLine($"Now retrying... (Retry: {retries})");
                }
            }

            throw new HttpRequestException($"Failed after {retries} retries");
        }

        public async Task<byte[]> SendRequest(Uri url)
        {
            HttpResponseMessage response = null;

            short retries = 0;

            while (retries++ < settings.MaxRetries - 1)
            {
                try
                {
                    response = await client.GetAsync(url);
                }
                catch (Exception)
                {
                    Console.WriteLine("An exception occured while processing the request, This may be due because you're not connected to the internet.");
                }

                if (response != null && response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsByteArrayAsync();
                }
                else
                {
                    await HandleError(response);

                    Console.WriteLine($"Now retrying... (Retry: {retries})");
                }
            }

            throw new HttpRequestException($"Failed after {retries} retries");
        }

        public async Task HandleError(HttpResponseMessage response)
        {
            Console.Write("An Error Occured: ");

            if (response == null)
                return;

            int statusCode = (int)response.StatusCode;

            if (statusCode == 520)
            {
                Console.WriteLine("The API returned an unexpected result");
            }
            else if (statusCode == 522)
            {
                Console.WriteLine("The request timed out");
                Console.WriteLine("This may be be either due to a bad connection or the API is down");
            }
            else
            {
                if (response.Content.Headers.ContentType != null)
                {
                    string mediaType = response.Content.Headers.ContentType.MediaType;

                    if (mediaType == "text/html")
                    {
                        throw new NotImplementedException("Method doesn't exist or isn't allowed");
                    }
                    else if (mediaType == "application/json")
                    {
                        var serializedResponse = await response.Content.ReadAsStringAsync();
                        var apiResponse = JsonSerializer.Deserialize<APIResponse<DestinyErrorResponse>>(serializedResponse);
                        Console.WriteLine(apiResponse.Message);
                    }
                    else
                    {
                        throw new HttpRequestException($"Failed due to an unknown error (HTTP error code {statusCode})");
                    }
                }
                else
                {
                    throw new HttpRequestException($"Failed due to an unknown error (HTTP error code {statusCode})");
                }
            }
        }
    }
}