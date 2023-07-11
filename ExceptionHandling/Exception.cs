using System;

public class Program
{
    class ExceptionHandling
    {
        try
        {
            
            int a = 10;
            int b = 0;
            int result = a / b;

            Console.WriteLine("Result: " + result); // This line will not be executed
        }
        catch (DivideByZeroException ex)
        {
           
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        catch (Exception ex)
        {
          
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
           
            Console.WriteLine("The program has completed.");
            Console.ReadLine();
        }

    }
}
