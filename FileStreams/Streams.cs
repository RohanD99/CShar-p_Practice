using System;
using System.IO;

public class Program
{
    class File
    {
       
        string filePath = "sample.txt";
        string content = "Hello, world!";

        
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(content);
        }

        Console.WriteLine("Content written to file.");

       
        using (StreamReader reader = new StreamReader(filePath))
        {
            string fileContent = reader.ReadToEnd();
            Console.WriteLine("File content: " + fileContent);
        }

        Console.ReadLine();
    }
}
