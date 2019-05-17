using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lesson_5
{
    class Task1
    {
        static void Main(string[] args)
        {
            string login, pat;
            bool flag;
            do
            {
                Console.WriteLine("Введите логин (от 2 до 10 символов, первый символ не цифра, только цифры и латинские буквы)");
                login = Console.ReadLine();
                pat = @"[a-zA-Z][a-zA-Z0-9]{1,9}";
                Regex reg = new Regex(pat);
                flag = reg.IsMatch(pat);
            }
            while (flag == false);
            Console.WriteLine($"Пароль соответствует требованиям - {login}");
            Console.ReadKey();

            //if (reg.IsMatch(login))
            //{
            //    Console.WriteLine($"Пароль соответствует требованиям - {login}");
            //}
            //else
            //{
            //    Console.WriteLine($"Пароль не соответствует требованиям - {login}");
            //}
            // Console.ReadKey();
        }
    }
}
