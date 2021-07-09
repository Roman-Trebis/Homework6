using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите своё имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите свой возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Твоё имя: {name}!\nВаш возраст: {age} лет.");

            if (age >= 18)
            {
                Console.WriteLine("Вы, совершеннолетний!");
            }

            else
            {
                Console.WriteLine("Вы, несовершеннолетний!");
            }
        }
    }
}
