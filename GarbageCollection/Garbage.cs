using System;

public class MyResource : IDisposable
{
    public MyResource()
    {
        Console.WriteLine("Resource acquired.");
    }

    public void DoSomething()
    {
        Console.WriteLine("Doing something with the resource.");
    }

    public void Dispose()
    {
        Console.WriteLine("Resource released.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        using (MyResource resource = new MyResource())
        {
            resource.DoSomething();
        }

        Console.WriteLine("Program completed.");
        Console.ReadLine();
    }
    
}
