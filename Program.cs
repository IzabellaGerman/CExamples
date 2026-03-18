using System;

namespace ConsoleApp1
    {  /*The task is to find prime numbers in the range from 1 to 1,000,000. 
        * write a method to check whether a number is prime and use it to count how many such numbers there are.
        * At the beginning of the loop,  record the current time; after the loop finishes,
        *  subtract the saved time from the current time and display the result on the screen.*/

    class Program
    {
        static bool ItIsSimple(int n)
        {
            int s = 2;
            for (s = 2; s < n/2 ; s++)
             
                if (n % s == 0) return true; return false;            
            
        }
        static void Main()
        {
            DateTime start = DateTime.Now;

            int k = 0;
            int i = 2;

            for (i = 2; i < 1000; i++)
            {
                if (ItIsSimple(i))
                {
                    k++;
                    Console.WriteLine("{0} {1}", k, i);
                }
            }
            Console.WriteLine($"Время: {DateTime.Now - start}");

        }
    }
}
