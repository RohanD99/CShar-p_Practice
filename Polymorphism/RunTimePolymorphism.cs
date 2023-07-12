using System;


class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("This is parent class");
    }
}

class Dog : Animal
{
    //overriding same method
    public override void Sound()
    {
        Console.WriteLine("Dogs bark");
    }
}

class Test
{
    static void Main(string[] args)
    {
        Dog d = new Dog();
        d.Sound();
    }
}