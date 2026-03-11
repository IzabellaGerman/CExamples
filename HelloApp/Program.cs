using System; //подключаемое пространство имен

namespace HelloApp //объявление нового пространства имен
{
    class Program // нового класса
    {
        static void Main(string[] args) //объявление нового метода
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");
           // Console.WriteLine("Hello World!");//действия метода
        } //конец  объявления нового метода

    } //конец объявление нового класса

}// конец пространства имен