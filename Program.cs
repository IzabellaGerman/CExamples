using System;

namespace ConsoleApp1
{
    /*Write a program that, in a sequence of integers, 
     * determines the arithmetic mean of positive numbers
     * that are divisible by 8.The program receives integers as input; 
     * among them, there is at least one positive number divisible by 8. 
     * The number of input values is unknown.
     * The sequence ends with the number 0
     * (0 is a termination signal and is not included in the sequence).*/

    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int s = 0;
            int a = int.Parse(Console.ReadLine());
            while (a != 0)
            { if (a > 0 && a % 8 == 0)
                { k++; s = s + a;}
                a = int.Parse(Console.ReadLine());//parse - преобразует только строку в инт, в конверт преобразует любой тип в строку
            }

            if (k > 0) Console.WriteLine(s / k);
        }
    }
}
