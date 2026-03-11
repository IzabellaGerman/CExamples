using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Izabella";
            byte Age = 33;
            bool IsEmpl = false;
            float Weight = 53.2F;

            WriteLine($"Your name: {Name}");
            WriteLine($"Your age: {Age} years");
            WriteLine($"Work: {IsEmpl}");
            WriteLine($"Your weght: {Weight} kgs");
            WriteLine($"Your name: {Name}; Your age: {Age} years; Work: {IsEmpl}; Your weght: {Weight} kgs.");
            WriteLine("Your name: {0}; your age: {3} years; work: {1}; your weght: {2} kgs.", Name, IsEmpl, Weight, Age );
            WriteLine("");

            WriteLine("Enter Your name: ");
            string name = ReadLine();

            WriteLine("Enter your age: ");
            byte age = Convert.ToByte(ReadLine());

            WriteLine("Enter your heght: ");
            double heidht = Convert.ToDouble(ReadLine());

            WriteLine("Enter your weght, kgs: ");
            double weight = Convert.ToDouble(ReadLine());

            WriteLine($"Your data: Name - {name}, Age - {age} years, heght - {heidht} cm, weght - {weight} kg");
        }
    }
}
