using System;

public class Program
{
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Enum
    {   
        DaysOfWeek today = DaysOfWeek.Wednesday;
        Console.WriteLine("Today is: " + today);
        Console.ReadLine();
        // Comparing enum values
        if (today == DaysOfWeek.Wednesday)
        {
            Console.WriteLine("It's Wednesday!");
        }

        // Enum iteration
        Console.WriteLine("All days of the week:");
        foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
        {
            Console.WriteLine(day);
        }

        string userInput = "Friday";
        if (Enum.TryParse(userInput, out DaysOfWeek parsedDay))
        {
            Console.WriteLine("Parsed day: " + parsedDay);
        }
        else
        {
            Console.WriteLine("Invalid day input");
        }
        Console.ReadLine();
    }
}
