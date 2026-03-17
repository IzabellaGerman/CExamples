using System;

namespace ConsoleApp1
{
    class Program
    {
        //работает по алгоритму Евклида. Есть вариант с делением 
        //наиб общ делитель
        static double NOD1(double a, double b)
        {
            while (a != b)
            
                if (a > b) a = a - b;  else b = b - a;
                return a;
                  
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"NOD {a} and {b} is {NOD1(a,b)}");
        }
    }
}
