using System;

public class MyClass
{
    public static int InstanceCount { get; private set; }

    static MyClass()
    {
        InstanceCount = 0;
        Console.WriteLine("Static constructor called");
    }

    public MyClass()
    {
        InstanceCount++;
        Console.WriteLine("Instance created");
    }
}

public class Program
{
    class StaticCtr
    {
        Console.WriteLine("Creating instances:");
        MyClass obj1 = new MyClass();
        MyClass obj2 = new MyClass();
        MyClass obj3 = new MyClass();

        Console.WriteLine();
        Console.WriteLine("Instance count: " + MyClass.InstanceCount);

        Console.ReadLine();
    }
}
