using System;

namespace HomeworkIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Жакып Аспандияр!!!");

            Console.WriteLine("Введите число!");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число!");

            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваша сумма!");

            Console.WriteLine(a + b);

            Console.ReadLine();
        }
    }
}
