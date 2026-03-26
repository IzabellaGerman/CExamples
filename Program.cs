using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[7];

            Console.WriteLine("Enter 7 elements");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("{0} number  ", i + 1);
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }

          
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        /*  temp = mas[i];
                          mas[i] = mas[j];
                          mas[j] = temp;*/
                        mas[i] = mas[i] + mas[j];
                        mas[j] = mas[i] - mas[j];
                        mas[i] = mas[i] - mas[j];
                    }
                }
            
            }

            Console.WriteLine("Sorted array: ");
            foreach (int i in mas)
            {
                Console.Write($" {i} ");
            }
        }
    }
}
