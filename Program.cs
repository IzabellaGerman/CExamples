using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод
            string hello = "Hello world!";
            Console.WriteLine(hello);
            Console.WriteLine("Welcome to C#");
            Console.WriteLine("Goodbye!");
            Console.WriteLine(24.5);

            string name = "Izabella";
            byte age = 34;
            double height = 170.5;

            Console.WriteLine($"Name: {name} Age: {age} years Height: {height} m");
            //Console.ReadKey();

            //Есть другой способ вывода на консоль сразу нескольких значений
            //закомментируй первый readkey, чтобы сработал второй вывод

            Console.WriteLine("Name: {0} Age {2} years  Height {1} m", name, height, age);
            //Console.ReadKey();

            //вывод

            Console.Write("Enter your name: ");
            string name2 = Console.ReadLine();
            Console.WriteLine($"Hi {name2}!");

        }
    }
}
