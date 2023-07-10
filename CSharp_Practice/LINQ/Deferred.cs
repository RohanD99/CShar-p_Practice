using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
   class DeferredExe
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        var query = numbers.Where(n => n % 2 == 0);

        numbers.Add(6); 

        // Executing the query
        Console.WriteLine("Even Numbers:");
        foreach (int number in query)
        {
            Console.WriteLine(number);
        }
        Console.ReadLine();
    }
}
