﻿using System;

namespace AnonymousWithLambda
{
    internal class Program
    {
        // Delegate Definition
        public delegate void CalculationDelegate(int a, int b);
        //static void Main(string[] args)
        class Delgate
        {
            CalculationDelegate calculationDelegate = delegate (int a, int b)
            {
                Console.WriteLine($"Addition: {a + b}");
            };

            Console.WriteLine("Anonymous Method Example:");
            calculationDelegate(1, 2);

            Console.WriteLine();

            // Lambda Expression Example
            CalculationDelegate calculationDelegateLambda = (a, b) =>
            {
                Console.WriteLine($"Multiplication: {a * b}");
            };

            Console.WriteLine("Lambda Expression Example:");
            calculationDelegateLambda(1, 3);
            Console.ReadLine();
        }

       
    }
}

