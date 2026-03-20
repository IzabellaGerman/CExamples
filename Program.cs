using System;

namespace ConsoleApp1
{
    class Program
        {   /*Write a program that displays the multiplication table on the console. */
        static void Main(string[] args)
        {
            int i = 1;
            int j = 1;
           
            for (i = 1; i <= 10; i++)
            { for (j = i; j <= 10; j++)
                {
                    Console.WriteLine(value: $"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
             
             }    

        }
    }
}
