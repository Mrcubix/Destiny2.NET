using System.Text;
using System.Text.Json;
using API.Entities.Response;

namespace API.Endpoints
{
    public class Destiny2
    {
        private HttpClient client = new();
        private JsonSerializerOptions serializerOptions;
        private string baseUrl = "https://www.bungie.net/Platform";

        public Destiny2()
        {
            serializerOptions = new() {
                PropertyNameCaseInsensitive = true
            };
        }
        
        public async Task<string> SendRequest(string method, Uri url, object body = null)
        {
            HttpResponseMessage response = null;
            HttpRequestMessage request = null;

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

                if (statusCode == 520) // Bungie broke everything, again
                {
                    Console.WriteLine("The API returned an unexpected result");
                }
                else if(statusCode == 522) // Let's be real, it's more likely that Bungie's API is down
                {
                    Console.WriteLine("The request timed out");
                    Console.WriteLine("This may be be either due to a bad connection or the API is down");
                }
                else
                {
                    if (response.Content.Headers.ContentType != null) // yes, this can happen
                    {
                        string mediaType = response.Content.Headers.ContentType.MediaType;

                        if (mediaType == "text/html") // Method not allowed
                        {
                            Console.WriteLine("Method doesn't exist or isn't allowed");
                            return null;
                        }
                        else if (mediaType == "application/json") // usually return a DestinyErrorResponse
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
            }
            return null;
        }
    }
}