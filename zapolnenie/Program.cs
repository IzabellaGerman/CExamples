using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace zapolnenie
{

  
    internal class Program
    {
        static void Main(string[] args)
        {
            //заполнение многомерного массива рандомом
            int[,] myArray = new int[10, 6];
            Random random = new Random();

            //набили массив
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(0,100);
                }
            }


            //WriteLine();
            //вывод
            for (int i = 0; i < myArray.GetLength(0); i++)
            { 
                WriteLine();    
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Write(myArray[i,j] + "\t");
                }
            }
            WriteLine();
            WriteLine("Fill manually");

            // заполнение многомерного массива рандомом
            int[,] myArray2 = new int[2, 3];


            //набили массив
            for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    WriteLine("Row " + i + " Coloumn2 " + j);
                    myArray2[i, j] = Convert.ToInt32(ReadLine()); 
                }
            }


            //WriteLine();
            //вывод
            for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                WriteLine();
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    Write(myArray2[i, j] + "\t");
                }
            }
            WriteLine();

        }
    }
}