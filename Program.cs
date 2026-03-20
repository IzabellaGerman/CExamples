using System;

namespace ConsoleApp1
{
    class Program
        {   /*Each month, the bank adds 7% of the deposit amount to the total.
            Write a console program in which the user enters the deposit amount and the number of months.
            The program should calculate the final deposit amount, taking into account the interest accrued each month.

            Use a for loop to calculate the amount with interest.
            To input the deposit amount, use the expression Convert.ToDecimal(Console.ReadLine())
            (the deposit amount will be of type decimal).*/

        private const decimal P = 0.07m;
        static void Main()
        {

            Console.WriteLine("Enter the deposit amount: ");
            decimal s = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the number of months: ");
            int t = Convert.ToInt32(Console.ReadLine());

            int i;
            for (i = 0; i <= t - 1; i++)  s = s + s * P; 

            Console.WriteLine($"The amount of your deposit after {t} months will be equal to {s:C}");

        }
    }
}
