using System;

//interface
public interface IShape
{
    void Draw();
}

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

//Virtual
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal is making a sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog is barking");
    }
}

//abstract
public abstract class Shape
{
    public abstract void Drawing();
}

public class Triangle : Shape
{
    public override void Drawing()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CallMethods();
    }

    public static void CallMethods()
    {
        IShape circle = new Circle();
        IShape rectangle = new Rectangle();
        circle.Draw();
        rectangle.Draw();

        Animal dog = new Dog();
        dog.MakeSound();

        Shape triangle = new Triangle();
        triangle.Drawing();
    }
}
