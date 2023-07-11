using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    class Interface
    {

        List<string> fruits = new List<string> { "Apple", "Banana", "Orange" };

        
        IEnumerator<string> enumerator = fruits.GetEnumerator();

        while (enumerator.MoveNext())
        {
            string fruit = enumerator.Current;
            Console.WriteLine(fruit);
        }

      
        enumerator.Reset();

        Console.WriteLine();

        // Iterate over the collection again
        while (enumerator.MoveNext())
        {
            string fruit = enumerator.Current;
            Console.WriteLine(fruit);
        }

        enumerator.Dispose();

        Console.ReadLine();
    }
}
