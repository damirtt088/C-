using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Task2
    {
        private string[] arr;
        string text;
        //int arrayDimension;
        /// <summary>
        /// Метод заполнения массива слов для сравнения
        /// </summary>
        /// <returns>строковый массив слов для сранения</returns>
        public static void ArrayActions(string[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Введите слова для сравнения");
                arr[i] = Console.ReadLine();
            }
        }

        
        /// <summary>
        /// метод "Вывод массива на экран"
        /// </summary>
        public static void Print(string[] arr)
        {
            Console.Write($"Ваш массив слов \n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Метод для посчета количества вхождений слов из массива слов в строке
        /// </summary>
        /// <returns>коллекцию слов и количества вхождений</returns>
        public Dictionary<string, int> Analysis()
        {
            Dictionary<string, int> numbers = new Dictionary<string, int>();
            foreach (var e in arr)
            {
                if (!numbers.ContainsKey(e))
                {
                    numbers.Add(e, 1);
                }
                else numbers[e]++;

            }
            return numbers;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество слов для сравнения");
            int arrayDimension = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[arrayDimension];
            ArrayActions(arr);
            Print(arr);
            Console.WriteLine("Введите текст для сравнения");
            string text = Console.ReadLine();
            string[] words = text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            var res = words.Analysis();
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res);
            }
            Console.ReadKey();
           

        }
    }
}
