using System;

public struct Point
{
    public int X;
    public int Y;
    int? a = null;
    int? b = 2;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
        a = null;
        b = 2;
    }

    public void Display()
    {
        Console.WriteLine($"X: {X}, Y: {Y},a: {a},b: {b}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
        Point p1 = new Point(10, 20);
        Point p2 = p1;

        // Modifying p2
        p2.X = 30;
        p2.Y = 40;
       

        // Displaying both struct instances
        p1.Display(); 
        p2.Display(); 
    }
}
