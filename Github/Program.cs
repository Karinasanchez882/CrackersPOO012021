﻿using System;

namespace Github
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a=0 , b=0;
            Console.WriteLine("Enter a value for a: ");
            a=Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b :");
            b=Int32.Parse(Console.ReadLine());

            Console.WriteLine($"multiplying {a} * {b} equals {AddNumbers (a , b) }");

        }
        public static int AddNumbers(int a , int b)
        {
            return a * b;
        }
    }
}
