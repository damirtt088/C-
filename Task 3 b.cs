// Мухаметшин Дамир Рустемович
// Домашнее задание по курсу "C# Уровень 1" 
// Урок №1
// Задание № 3 б
// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
// б) * Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_b
{
    class Program
    {
        static double Distance (double X1, double X2, double Y1, double Y2)
        {
            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату Х для 1 точки");
            double X1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату Y для 1 точки");
            double Y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату Х для 2 точки");
            double X2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату Y для 2 точки");
            double Y2 = Convert.ToDouble(Console.ReadLine());
                  
            Console.WriteLine("Расстояние между точками = {0:F2}", Distance(X1, X2, Y1, Y2));
            Console.ReadLine();
        }
    }
}
