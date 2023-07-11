using System;

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public static class MathUtils
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

public class Program
{
    class Types
    {
        // Abstract 
        Shape rectangle = new Rectangle { Width = 5, Height = 3 };
        double area = rectangle.CalculateArea();
        Console.WriteLine("Rectangle Area: " + area);

        // Static
        int sum = MathUtils.Add(4, 5);
        int product = MathUtils.Multiply(2, 3);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Product: " + product);

        Console.ReadLine();
    }
}
