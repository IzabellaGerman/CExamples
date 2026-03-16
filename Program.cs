using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the value of a function at the point
            int a = 1;
            int b = 2;
            int c = 3;

            Console.WriteLine("Enter x = ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = a * Math.Pow(x, 2) + b * x + c;
             Console.WriteLine("x^2 + {1}*x + c, when x = {2} y = {3}", a, b, c, y); 

        }
    }
}
