// Мухаметшин Дамир Рустемович
// Домашнее задание по курсу "C# Уровень 1" 
// Урок №2
// Задание № 2
// Написать метод подсчета количества цифр числа.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int count = 0;
            do
            {
                number = number / 10;
                count = count + 1;
            }
            while (number > 0);

            Console.WriteLine($"Количество цифр в числе : {count}");
            Console.ReadLine();
        }
    }
}
