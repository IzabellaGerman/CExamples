using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //exchange the value of variables without using additional vaariables
            Console.WriteLine("Enter a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b:");
            double b = Convert.ToDouble(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a = {a} b = {b}");

        }
    }
}
