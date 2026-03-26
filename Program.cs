using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = {9, -2, 0 ,3, 6, 8, -1};
            foreach (int i in mas)
            {
                Write($"{i} ");
            }

            WriteLine();

            int temp;
            int n = mas.Length;
            int k = n / 2;

            for (int i = 0; i < k; i++)
            {
                temp = mas[i];
                mas[i] = mas[n - i - 1];
                mas[n - i - 1] = temp;
            }

            foreach (int i in mas) 
            {
                Write($"{i} ");
            }

            
        }
    }
}
