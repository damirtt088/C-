using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3
{
    class MyArray
    {
        int[] a;

        //  Создание массива и заполнение его случайными числами от min до max
        /// <summary>
        /// Метод заполнения массива
        /// </summary>
        /// <param name="n">кол-во элементов в массиве</param>
        /// <param name="min">минимальный предел</param>
        /// <param name="max">максимальный предел</param>
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        /// <summary>
        /// Свойство индексирования для обращения к отдельному элементу массива
        /// </summary>
        /// <param name="index">отдельный элемент массива</param>
        /// <returns>отдельный элемент массива</returns>
        public int this[int index]
        {
            get { return a[index]; }
            set { a[index] = value; }
        }

        /// <summary>
        /// метод "Вывод массива на экран"
        /// </summary>
        public void MyArrayPrint()
        {
            Console.Write($"Ваш массив \n");
            foreach (int i in a)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Метод нахождения пар элементов, где один делится нацело на "3"
        /// </summary>
        /// <returns>Количество пар</returns>
        public int Compare()
        {
            int theNumberPairsElements = 0;
            for (int i = 0; i < a.Length - 1; i++)
                if (a[i] % 3 == 0 ^ a[i + 1] % 3 == 0)
                    theNumberPairsElements++;
            return theNumberPairsElements;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(6, -10, 10);
            a.MyArrayPrint();
            int t = a.Compare();
            Console.WriteLine($"\n Количество пар {t}");
            Console.ReadKey();
        }
    }

}
