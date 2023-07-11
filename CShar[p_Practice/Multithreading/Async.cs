using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Starting the program.");

        await LongRunningOperation();

        Console.WriteLine("Program completed.");
    }

    public static async Task LongRunningOperation()
    {
        Console.WriteLine("Long running operation started.");

    
        await Task.Delay(1000);

        Console.WriteLine("Long running operation completed.");
        Console.ReadLine();
    }
}
