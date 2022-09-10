using System.Security.Authentication;
using System.Text;
using System.Text.Json;
using API.Entities.Request.User;
using API.Entities.Response;
using API.Entities.Response.Base;

namespace API.Endpoints
{
    public class Destiny2
    {
        private HttpClient client = new();
        private JsonSerializerOptions serializerOptions;
        private string baseUrl = "https://www.bungie.net/Platform";
        private Settings settings;
        public static InvalidCredentialException InvalidAPIKeyException = new("The API Key provided is invalid");
        public static HttpRequestException requestProcessingErrorResponse = new("There was an issue processing the request.");

        public Destiny2(Settings settings)
        {
            this.settings = settings;

            if (settings.Key == null)
            {
                Console.WriteLine("The API key in the provided settings was null");
            }
            else
            {
                client.DefaultRequestHeaders.Add("x-api-key", settings.Key);
            }

            serializerOptions = new() {
                PropertyNameCaseInsensitive = true
            };
        }

        public async Task<APIResponse> SearchDestinyPlayerByBungieName(string name, short tag)
        {
            if (string.IsNullOrEmpty(settings.Key))
                throw InvalidAPIKeyException;

            ExactSearchRequest body = new();
            body.displayName = name;
            body.displayNameCode = tag;

            string serializedResponse = await SendRequest("POST", new($"{baseUrl}/Destiny2/SearchDestinyPlayerByBungieName/all"), body);
            
            if (serializedResponse == null)
                throw requestProcessingErrorResponse;

            return JsonSerializer.Deserialize<PlayerSearchResponse>(serializedResponse, serializerOptions);
        }
        
        public async Task<string> SendRequest(string method, Uri url, object body = null)
        {
            HttpResponseMessage response = null;
            HttpRequestMessage request = null;

            short retries = 0;

            while(retries++ < settings.MaxRetries - 1)
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
                catch(Exception E)
                {
                    Console.Clear();
                    Console.WriteLine("An Exception Occured: ");
                    Console.WriteLine(E.ToString());
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadKey();
                    return null;
                }

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    Console.Clear();
                    Console.Write("An Error Occured: ");

                    int statusCode = (int)response.StatusCode;

                    if (statusCode == 520)
                    {
                        Console.WriteLine("The API returned an unexpected result");
                    }
                    else if(statusCode == 522)
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
                                Console.WriteLine("Method doesn't exist or isn't allowed");
                                return null;
                            }
                            else if (mediaType == "application/json")
                            {
                                var serializedResponse = await response.Content.ReadAsStringAsync();
                                var apiResponse = JsonSerializer.Deserialize<DestinyErrorResponse>(serializedResponse);
                                Console.WriteLine(apiResponse.Message);
                            }
                            else
                            {
                                Console.WriteLine($"Failed due to an unknown error (HTTP error code {statusCode})");
                                return null;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Failed due to an unknown error (HTTP error code {statusCode})");
                            return null;
                        }
                    }

                    Console.WriteLine($"Now retrying... (Retry: {retries})");
                }
            }

            Console.WriteLine($"Failed after {retries} retries");
            return null;
        }
    }
}