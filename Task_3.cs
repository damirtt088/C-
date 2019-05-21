using System;
using System;
using System.Collections;
using System.IO;
    class Program
{
    static void Main(string[] args)
    {
        int bakalavr = 0;
        int magistr = 0;
        // Создадим необобщенный список
        ArrayList list = new ArrayList();
        int[] mass = new int[list.Count];
        // Запомним время в начале обработки данных
        DateTime dt = DateTime.Now;
        StreamReader sr = new StreamReader("..\\..\\students_1.csv");
        while (!sr.EndOfStream)
        {
            try
            {
                string[] s = sr.ReadLine().Split(';');
                // Console.WriteLine("{0}", s[0], s[1], s[2], s[3], s[4]);
                list.Add(s[1] + " " + s[0]);// Добавляем склееные имя и фамилию
                if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
                if (int.Parse(s[5]) >= 18 ^ int.Parse(s[5]) <= 20)
                {
                    foreach (var v in list) mass[Convert.ToInt32(v)]++;
                }

            }
            catch
            {
            }
        }
        sr.Close();
        list.Sort();
        Console.WriteLine("Всего студентов:{0}", list.Count);
        Console.WriteLine("Магистров:{0}", magistr);
        Console.WriteLine("Бакалавров:{0}", bakalavr);
        Console.WriteLine("Количество студентов на 5 и 6 курсах:{0}", magistr);
        foreach (var v in mass) Console.WriteLine(v);
        // Вычислим время обработки данных
        Console.WriteLine(DateTime.Now - dt);
        Console.ReadKey();
    }
}

