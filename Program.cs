using System;

namespace ConsoleApp1
{
    class Program
    {
        //Print all numbers in the range from 10 to 100 whose sum of the last two digits is equal to 10:
        //19, 28, 37, 46, 55, 64, 73, 82, 91
        static bool sum_numbers(int i)
        {
            if ( i%10 + i/10%10 == 10) return true; else return false;
        }
        static void Main(string[] args)
        {
            int i;

            for (i = 10; i <= 100; i++)
            {
                if (sum_numbers(i))
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
