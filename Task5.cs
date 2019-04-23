// Мухаметшин Дамир Рустемович
// Домашнее задание по курсу "C# Уровень 1" 
// Урок №2
// Задание № 5
// а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
// б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Task5
    {
        static double MassIn(double growth, double weight) => (weight / Math.Pow(growth,2));
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            Console.WriteLine("Введите рост в метрах: ");
            double growth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вес в килограммах: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double In = (MassIn(growth, weight));

            Console.WriteLine($"Индекс массы тела = {In:F2}");
            Console.WriteLine("Интерпретация показателей ИМТ\n");

            if (In <= 16) { Console.WriteLine("Выраженный дефицит массы тела\n"); }
            if (In > 16 && In <= 18.5) { Console.WriteLine("Недостаточная (дефицит) масса тела\n"); }
            if (In > 18.5 && In <= 24.99) { Console.WriteLine("Норма\n"); }
            if (In > 25 && In <= 30) { Console.WriteLine("Избыточная масса тела (предожирение)\n"); }
            if (In > 30 && In <= 35) { Console.WriteLine("Ожирение\n"); }
            if (In > 35 && In <= 40) { Console.WriteLine("Ожирение резкое\n"); }
            if (In > 40) { Console.WriteLine("Очень резкое ожирение\n"); }

            if (In < 18.5) { Console.WriteLine($"Необходимо набрать минимум {((18.5 * Math.Pow(growth, 2)) - weight):F3} кг"); }
            if (In > 18.5 && In <= 24.99) { Console.WriteLine($"Все хорошо. И худеть не надо и поправляться тоже не надо"); }
            if (In > 25) { Console.WriteLine($"Необходимо похудеть минимум на {(weight - (25 * Math.Pow(growth, 2))):F3} кг"); }

            Console.ReadLine();
        }
    }
}
