using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayActions
{
    class ArrayActions
    {
        private int[] arr;
        private int sum;
        private int count;

        /// <summary>
        /// конструктор "Задание массива"
        /// </summary>
        /// <param name="arrayDimension">количество элементов в массиве</param>
        /// <param name="OriginalValue">начальное значение</param>
        /// <param name="StepValue">шаг изменения данных</param>
        public ArrayActions(int arrayDimension, int OriginalValue, int StepValue)
        {
            arr = new int[arrayDimension];
            for (int i = 1; i < arrayDimension; i++)
            {
                arr[0] = OriginalValue;
                arr[i] = arr[i - 1] + StepValue;
            }
        }
        /// <summary>
        /// Свойство "Доступ к i-ому элементу массива"
        /// </summary>
        /// <param name="i">i-ый элемент массива</param>
        /// <returns></returns>
        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        /// <summary>
        /// метод "Вывод массива на экран"
        /// </summary>
        public void ArrayPrint()
        {
            Console.Write($"Ваш массив \n");
            foreach (int i in arr)
            {
                Console.WriteLine($"{i} ");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Свойство "Количество максимальных элементов"
        /// </summary>
        public int MaxCount
        {
            get
            {
                int count = 0;
                int m = arr[0];                                // Можно просто использовать int m = arr.Max();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (m < arr[i])
                    {
                        m = arr[i];
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == m)
                    {
                        count += 1;
                    }

                }
                return count;
            }
            set { count = value; }
        }
        /// <summary>
        /// Свойство "Сумма элементов массива"
        /// </summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (int i in arr)
                {
                    sum += i;
                }
                return sum;
            }
            set { sum = value; }
        }

        /// <summary>
        /// Метод "умножение всех элементов масива на "-1""
        /// </summary>
        /// <param name="arr">массив</param>
        /// <returns>массив умноженный на "-1"</returns>
        public void Inverse()
        {
            int[] tempArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                tempArr[i] = -arr[i];
            }
        }

        /// <summary>
        /// Метод "Умножение элементов массива на множитель"
        /// </summary>
        /// <param name="MultiplicationNumber">число для умножения</param>
        public void Multi(int MultiplicationNumber)
        {
            int[] tempArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                tempArr[i] = MultiplicationNumber * arr[i];
            }

        }

    }

    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите размерность массива");
            int arrayDimension = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите начальное значение");
            int OriginalValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите шаг изменения значений");
            int StepValue = Convert.ToInt32(Console.ReadLine());
            ArrayActions array = new ArrayActions(arrayDimension, OriginalValue, StepValue);      //Создание  экземпляра класса (массива array).
                                                                                                  // ArrayActions array1 = new ArrayActions(arrayDimension, OriginalValue, StepValue);     //Создание  экземпляра класса (массива array1). Это полная копия массива array (по условию задачи старый массив надо оставить "как есть")
            ArrayActions array1 = (ArrayActions)array.Clone();
            array.ArrayPrint();
            array1.ArrayPrint();
            Console.WriteLine($"\n Сумма {array.Sum}");
            Console.ReadKey();
            Console.WriteLine($"\n Массив с измененными знаками у всех элементов \n");
            array1.Inverse();
            array1.ArrayPrint();
            Console.WriteLine($"Введите число для умножения");
            int MultiplicationNumber = Convert.ToInt32(Console.ReadLine());
            array.Multi(MultiplicationNumber);                                                  // Ошибку не выдает, но не возвращает массив, элементы которого умножены на множитель MultiplicationNumber
            array.ArrayPrint();
            Console.WriteLine($"Количество максимальных элементов {array.MaxCount}");
            Console.ReadKey();
        }
    }
}

           