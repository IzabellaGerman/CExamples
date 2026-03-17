using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, max;
            Console.WriteLine("Enter number 1:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 3:");
            num3 = Convert.ToInt32(Console.ReadLine());


            //option 1
            if (num1 > num2 && num1 > num3 ) 
            {
                Console.WriteLine($"Max = {num1}");
            }
            else 
            { if (num2 > num3)
                {
                    Console.WriteLine($"Max = {num2}");
                }
                else
                {
                    Console.WriteLine($"Max = {num3}");
                }
            };

            //option 2
            max = num1;
            if (num2 > max)
            {
                max = num2;
            };
           
            if (num3 > max)
            {
                max = num3;
            };
              
            Console.WriteLine($"Max = {max}");




        }
    }
}
