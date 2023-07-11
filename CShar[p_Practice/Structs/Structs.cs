using System;

public struct Person
{
    public string Name;
    public int Age;
    public bool IsStudent;

    public Person(string name, int age, bool isStudent)
    {
        Name = name;
        Age = age;
        IsStudent = isStudent;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Is Student: " + IsStudent);
    }
}

public class Program
{
    class Structs
    {
        Person person1 = new Person("John", 25, false);
        person1.PrintDetails();

        Console.WriteLine();

        Person person2 = new Person("Alice", 21, true);
        person2.PrintDetails();
        Console.ReadLine();
    }
}
