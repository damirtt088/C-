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
            Console.WriteLine("Введите первую последовательность букв для сравнения");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую последовательность букв для сравнения");
            string str2 = Console.ReadLine();
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Строки s1 и s2 не являются перестановкой");
            }
            else
            {
                string str1_1 = str1.ToLower();
                string str2_1 = str2.ToLower();
                str1_1.OrderByDescending(x => x);
                str2_1.OrderByDescending(x => x);
                if (str1_1.SequenceEqual(str2_1))
                {
                    Console.WriteLine("Строки s1 и s2 являются перестановкой");
                }
                else
                {
                    Console.WriteLine("Строки s1 и s2 не являются перестановкой");
                }
            }           
            Console.ReadLine();
           
        }
    }
}
