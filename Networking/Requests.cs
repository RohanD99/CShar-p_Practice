using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

public class Request
{
    public static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            // GET request to /posts
            HttpResponseMessage getResponse = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
            HttpWebResponse webResponse = await client.BaseAddress + getResponse.Content.ReadAsStringAsync();

            if (getResponse.IsSuccessStatusCode)
            {
                string responseContent = await getResponse.Content.ReadAsStringAsync();
                Console.WriteLine("GET Response:");
                Console.WriteLine(responseContent);
            }
            else
            {
                Console.WriteLine("GET Request failed with status code: " + getResponse.StatusCode);
            }

            Console.WriteLine();

            // POST request
            string postData = "Some data to send";
            HttpResponseMessage postResponse = await client.PostAsync("https://jsonplaceholder.typicode.com/posts", new StringContent(postData));

            if (postResponse.IsSuccessStatusCode)
            {
                string responseContent = await postResponse.Content.ReadAsStringAsync();
                Console.WriteLine("POST Response:");
                Console.WriteLine(responseContent);
            }
            else
            {
                Console.WriteLine("POST Request failed with status code: " + postResponse.StatusCode);
            }

            Console.WriteLine();

            // PUT request
            string putData = "Updated data";
            HttpResponseMessage putResponse = await client.PutAsync("https://jsonplaceholder.typicode.com/posts/1", new StringContent(putData));

            if (putResponse.IsSuccessStatusCode)
            {
                string responseContent = await putResponse.Content.ReadAsStringAsync();
                Console.WriteLine("PUT Response:");
                Console.WriteLine(responseContent);
            }
            else
            {
                Console.WriteLine("PUT Request failed with status code: " + putResponse.StatusCode);
            }

            Console.WriteLine();

            // DELETE request
            HttpResponseMessage deleteResponse = await client.DeleteAsync("https://jsonplaceholder.typicode.com/posts/1");

            if (deleteResponse.IsSuccessStatusCode)
            {
                Console.WriteLine("DELETE Request successful.");
            }
            else
            {
                Console.WriteLine("DELETE Request failed with status code: " + deleteResponse.StatusCode);
            }
        }
    }
}
