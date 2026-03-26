using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] mas = { {{ 1, 2 }, { 3, 4 } },
                            { { 5, 6}, { 7, 8} },
                            { { 9, 10}, { 11, 12} },
                            { { 13, 14},{ 15, 16} } };

            /*простой вывод без скобок
             * int l = mas.Length;
             int i = 0;


             foreach (int row in mas)
             {
                 i+= (int)1;

                 if (i != l) { Console.Write($"{row}, "); }
                 else { Console.Write($"{row} "); };

             }
            */

            //output of a three-dimensional array with iteration of rows, columns, and depth
            int l = mas.Length;

             Console.Write("{ "); 
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write("{ ");
                    for (int k = 0; k < mas.GetLength(2); k++)
                    {
                        if (((i + 1)*(j + 1)*(k + 1)) != l)
                          { Console.Write($"{mas[i, j, k]}, "); }
                      else
                          { Console.Write($"{mas[i, j, k]} "); };
                       
                    }
                    Console.Write("} ");
                }
                Console.Write("} ");
            }
            Console.Write("} ");


        }
    }
}
