using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main()
        {
            // Replace the URL with the actual endpoint you want to call
            string apiUrl = "https://www.google.com/";

            //new comment 1
            // Create an instance of HttpClient
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Make the GET request
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    // Check if the request was successful (status code 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Read and output the response content
                        string content = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Response Content: {content}");
                    }
                    else
                    {
                        Console.WriteLine($"Request failed with status code: {response.StatusCode}");
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
