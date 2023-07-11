using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Project1;

namespace CShar_p_Practice.Debugging
{
    public static void Main(string[] args)
    {
        // Start stopwatch to measure the elapsed time
        Stopwatch stopwatch = Stopwatch.StartNew();

        // Simulate some time-consuming operation
        DoSomeTimeConsumingTask();

        // Stop the stopwatch and display elapsed time
        stopwatch.Stop();
        TimeSpan elapsedTime = stopwatch.Elapsed;
        Console.WriteLine($"Elapsed Time: {elapsedTime.TotalSeconds} seconds");

        // Writing a debug message
        Debug.WriteLine("This is a debug message");

        // Asserting a condition for debugging purposes
        Debug.Assert(elapsedTime.TotalSeconds > 5, "Elapsed time should be greater than 5 seconds");

        // Using Trace to log information
        Trace.WriteLine("This is a trace message");
    }

    public static void DoSomeTimeConsumingTask()
    {
        // Simulating a time-consuming operation
        for (int i = 0; i < 1000000; i++)
        {
            // Perform some computation
        }
    }
}
