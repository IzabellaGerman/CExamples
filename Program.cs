using System;

namespace ConsoleApp1
    { /*Write a program in which the user enters two numbers and displays the result of their multiplication.
        The program should prompt the user for further input until both numbers are between 0 and 10.
        If the entered numbers are greater than 10 or less than 0, the program should display a message to the user indicating that the entered numbers are invalid and prompt the user again for two numbers.
        If the entered numbers are between 0 and 10, the program displays the result of the multiplication.

        To organize the number input, use an infinite while loop and the break statement..
    */

    class Program
    {
        static int Umn(int a ,int b)
        {
             int s = 0;
             s = a * b;
             return s;
        }

        static void Main(string[] args)
        {
            int i = 0;
            int a = 0;
            int b = 0;

            do
            {
                Console.WriteLine("Enter a: ");          //enter а
                a = Convert.ToInt32(Console.ReadLine()); //convert to int

                if (a <= 0 || a > 10)                      //check a
                {
                    Console.WriteLine("Wrong a");        // message
                    //continue;                            //stop cycle
                }
            }
            while (a <= 0 || a > 10);

            do
            {
                Console.WriteLine("Enter b: ");          //enter b
                b = Convert.ToInt32(Console.ReadLine()); //convert to int

                if (b <= 0 || b > 10)                      //check b
                {
                    Console.WriteLine("Wrong b");        // message
                    //continue;                            //stop cycle
                }
            }
            while (b <= 0 || b > 10);

            i = Umn(a, b);
            Console.WriteLine($" {a} * {b} = {i}");
        }
    }
}
