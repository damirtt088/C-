// Мухаметшин Дамир Рустемович
// Домашнее задание по курсу "C# Уровень 1" 
// Урок №2
// Задание № 3
// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            int number;
            int summa = 0;
            do
            {
                Console.WriteLine("Введите целое число: ");
                number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                if (number > 0 && number % 2 == 1)
                {
                    summa += number; 
                }
            }
            while (number != 0);

           Console.WriteLine($"Сумма введенных нечетных цифр : {summa}");
           Console.ReadLine();
        }
    }
}
