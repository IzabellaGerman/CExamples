using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { {1, 2, 3 }, {4, 5, 6 }, {7, 8, 9} };

            int rows = num.GetUpperBound(0) + 1;
            int colomns = num.Length / rows; // int colomns = num.GetUpperBound(1)+1

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colomns; j++)
                {
                    Console.Write($"{num[i, j]} \t");
                }
                Console.WriteLine();
                Console.WriteLine();

            }
        }
    }
}
