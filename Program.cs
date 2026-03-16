using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Odd:");
            Console.WriteLine(Odd(x));
            Console.ReadKey();

        }

        static bool Odd(int a)
        {
            return a % 2 != 0;

        }
    }
}
