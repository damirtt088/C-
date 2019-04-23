// Мухаметшин Дамир Рустемович
// Домашнее задание по курсу "C# Уровень 1" 
// Урок №2
// Задание № 3
// Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
// С помощью цикла do while ограничить ввод пароля тремя попытками.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            int count = 1;
            string TrueLogin = "root";
            string TruePassword = "GeekBrains";
            do
            {
                Console.WriteLine($"Попытка входа в систему : {count}");
                Console.WriteLine("Введите логин: ");
                string Login = Console.ReadLine();
                Console.WriteLine("Введите пароль: ");
                string Password = Console.ReadLine();
                count++;

                if (TrueLogin == Login && TruePassword == Password)
                {
                    Console.WriteLine($"Доступ разрешен!");
                    break;
                }
                else
                    Console.WriteLine($"Доступ запрещен!");
            }
            while (count < 4);
            Console.ReadLine();
        }
    }
}
