using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    delegate double Func(double x);
    class Task_2
    {
        static double f1(double x)
        {
            return x * x;
        }

        static double f2(double x)
        {
            return Math.Log10(x);
        }


        static double f3(double x)
        {
            return Math.Sin(x);
        }


        static double f4(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static void SaveFunc(string fileName, Func min, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(min(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        static void Main(string[] args)
        {
            Func min;
            min = f4;
            SaveFunc("data.bin", f4, - 100, 100, 0.5);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();

            List<Func> funs = new List<Func>
            {
                f1,
                f2,
                f3,
                f4
            };
            Console.WriteLine("Выберите функцию \n 0 -возведение в квадрат \n 1- логарифмирование по основанию 10 \n 2-взятие синуса");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите аргумент функции");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(funs[a](b));
            Console.ReadKey();

        }


    }
}
