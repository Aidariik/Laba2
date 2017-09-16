using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double c = Math.Sqrt(a*a + b*b);
            System.Console.WriteLine(c);
            System.Console.Writeline("Kak dela?");
        }
    }
}
