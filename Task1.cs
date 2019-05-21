using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    // Описываем делегат. 
    public delegate double Fun(double y, double a);
       
    class Task1
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x, double b, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        /// <summary>
        /// метод MyFuncXCvadrat(a* sin(x)) для передачи его в качестве параметра в Table
        /// </summary>
        /// <param name="x">переменная для передачи в sin()</param>
        /// <param name="a">консольно задаваемый параметр для умножения на sin()</param>
        /// <returns>возвращает значение выражения a * Math.Sin(x)</returns>
        public static double MyFuncXCvadrat(double y, double a)
        {
            return a * Math.Sin(y);
        }
        
        /// <summary>
        /// метод MyFuncXSINUS (a*x*x) для передачи его в качестве параметра в Table
        /// </summary>
        /// <param name="x">параметр для возведения в квадрат</param>
        /// <param name="a">консольно задаваемый параметр для умножения на квадрат "х"</param>
        /// <returns>возвращает значение выражения a * x * x </returns>
        public static double MyFuncXSINUS(double y, double a)
        {
            return a * y * y;
        }
                     

        static void Main(string[] args)
        {
            Console.WriteLine("Введите параметр а ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите параметр x ");
            double y = Convert.ToDouble(Console.ReadLine());
            Fun F = MyFuncXCvadrat;
            Table(F, -2, 2, a);
            F = MyFuncXCvadrat;
            Table(F, -2, 2, a);
            Console.ReadKey();
                                                                             
            
        }
    }
}


