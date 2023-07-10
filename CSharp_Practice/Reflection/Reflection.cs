using System;
using System.Reflection;

public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        Console.WriteLine("Executing MyMethod");
    }
}

public class Program
{
    class Reflection
    {
   
        Type myClassType = typeof(MyClass);

        Console.WriteLine("Properties:");
        PropertyInfo[] properties = myClassType.GetProperties();
        foreach (var property in properties)
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine();

        // Get the methods of the class
        Console.WriteLine("Methods:");
        MethodInfo[] methods = myClassType.GetMethods();
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }

        Console.WriteLine();

        
        Console.WriteLine("Creating an instance of MyClass using reflection:");
        object myClassInstance = Activator.CreateInstance(myClassType);
        MyClass myClass = (MyClass)myClassInstance;

        // Set a property value using reflection
        PropertyInfo propertyInfo = myClassType.GetProperty("MyProperty");
        propertyInfo.SetValue(myClass, 42);

      
        MethodInfo methodInfo = myClassType.GetMethod("MyMethod");
        methodInfo.Invoke(myClass, null);

        // Access the property value using reflection
        int myPropertyValue = (int)propertyInfo.GetValue(myClass);
        Console.WriteLine("MyProperty value: " + myPropertyValue);
        Console.ReadLine();
    }
}
