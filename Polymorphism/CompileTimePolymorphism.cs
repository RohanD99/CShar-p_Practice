using System;

class Rectangle
{
    //same method name diff parameters
    public static void PrintArea(int x, int y)
    {
        Console.WriteLine(x * y);
    }
    public static void PrintArea(int x)
    {
        Console.WriteLine(x * x);
    }
    public static void PrintArea(int x, double y)
    {
        Console.WriteLine(x * y);
    }
    public static void PrintArea(double x)
    {
        Console.WriteLine(x * x);
    }
    static void Main(string[] args)
    {
        PrintArea(2, 4);
        PrintArea(2, 5.1);
        PrintArea(10);
        PrintArea(2.3);
        Console.ReadLine();
    }   
}