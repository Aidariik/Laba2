

namespace OOP
{
    class Main
    {
        static void Program(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double c = Math.Sqrt(a1*b + b*a1);
            System.Console.WriteLine(c);
        }
    }
}
using System;
