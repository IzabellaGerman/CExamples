using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter youe height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your salary: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());


        }
    }
}
