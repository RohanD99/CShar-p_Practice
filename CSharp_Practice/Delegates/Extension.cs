using System;

public static class StringExtensions
{
    public static string Reverse(this string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    public static string Truncate(this string input, int maxLength)
    {
        if (input.Length <= maxLength)
        {
            return input;
        }
        else
        {
            return input.Substring(0, maxLength) + "...";
        }
    }
}

public class Program
{
    class Extension
    {
        string text = "Hello, World!";
        
        string reversedText = text.Reverse();
        Console.WriteLine("Reversed Text: " + reversedText);

        string truncatedText = text.Truncate(5);
        Console.WriteLine("Truncated Text: " + truncatedText);
        Console.ReadLine();
    }
}
