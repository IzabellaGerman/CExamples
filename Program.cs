using System;
using static System.Console;
using static System.Math; 

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a = ");
            double a = Convert.ToDouble(ReadLine());

            Write("Enter b = ");
            double b = Convert.ToDouble(ReadLine());

            Write("Enter c = ");
            double c = Convert.ToDouble(ReadLine());

            WriteLine($"Equation {a}*x*x + {b}*x + {c} = 0");;

            double D = -1;
            D = (b * b - 4 * a * c);
            double x1 = 0;
            double x2 = 0;

            if (D > 0)
            {
                x1 = Math.Round((-b - Math.Sqrt(D)) / (2 * a), 2);
                x2 = Math.Round((-b + Math.Sqrt(D)) / (2 * a), 2);
                WriteLine($"Two solitions for the equation x1 = {x1}, x2 = {x2}");
            }
            else
            {
                if (D == 0) 
                {
                    x1 = -b / (2 * a);
                    WriteLine($"One solution x = {x1}");
                }
                else { WriteLine("No solution"); }
            }

        }
    }
}
