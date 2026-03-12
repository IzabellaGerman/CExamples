using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //логическое умножение
            int a = 101;
            int b = 010;
            Console.WriteLine(a&b);
            //результат 0, потому что не совпадает ни одно значение разрядов у чисел


            //логическое сложение
            int x1 = 2;// 100;
            int x2 = 5; // 101;
            Console.WriteLine(x1|x2);
            //результат 101, потому что есть хотя бы в одном разряде единица


            //логическое исключающее или 
            int a1 = 45;                //0101101
            int b1 = 102;               //1100110
            Console.WriteLine(a1^b1);   //1001011      
            //результат 75. если разряды разные, то возвращается единица

            //инверсия
            int x3 = 12;
            Console.WriteLine(~x3); // -13

            int y3 = 12;
            int y4 = ~y3;
            y4 += 1;
            Console.WriteLine(y4); // -12

            //сдвиг
            int q = 0b100; //4
            int w = 0b1;  //1
            Console.WriteLine(q<<w); //  8

            int e = 0b10;  //2
            Console.WriteLine(q<<e); //16
            Console.WriteLine(q>>w); //2
        }
    }
}
