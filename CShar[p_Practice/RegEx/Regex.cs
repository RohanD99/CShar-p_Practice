using System;
using System.Text.RegularExpressions;

public class Program
{
    class RegEx
    {
        string text = "The quick brown fox jumps over the lazy dog.";
       
        bool containsFox = Regex.IsMatch(text, @"\bfox\b");
        Console.WriteLine("Contains 'fox': " + containsFox);
 
        Console.WriteLine("Words starting with 'q':");
        MatchCollection matches = Regex.Matches(text, @"\bq\w+");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }

        string modifiedText = Regex.Replace(text, @"\blazy\b", "active");
        Console.WriteLine("Modified Text: " + modifiedText);
        Console.ReadLine();
    }
}
