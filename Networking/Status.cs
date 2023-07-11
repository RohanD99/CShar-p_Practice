class Program
{

    //status code
    static async Task Main(string[] args)
    {
        var client = new HttpClient();

        var available = await client.GetAsync("http://google.com");
        var unavailable = await client.GetAsync("http://rd.com");
        Console.WriteLine(available.StatusCode);
        Console.WriteLine(unavailable.StatusCode);
    }
}

