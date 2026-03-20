using System;

namespace ConsoleApp1
{
    class Program
    {
        static int Sum(int a)
        {
            int sm = 0;
            int i = 0;

            for (i = 0; i <= a; i++)
            
              if (i == 0)
                sm = 1; 
              else 
                sm *= i;
            return sm;
        }

        static void Main(string[] args)
        {
            int a = 0;

            Console.WriteLine("Enter number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial: {Sum(a)}");
        }
    }
}
