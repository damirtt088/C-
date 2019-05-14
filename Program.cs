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
            array.ArrayPrint();
            
            //Console.WriteLine($"Количество максимальных элементов {array.MaxCount}");
            //Console.ReadKey();


            Dictionary<int, int> numbers = new Dictionary<int, int>(); //(arrayDimension);
            {
                int k = 0;
                // int i = 0;
                int j = 1;
                int dictionaryDemension = 0;
                numbers.Add(array[0], dictionaryDemension);
                for (int i = 0; i < arrayDimension; i++)
                {
                    if (numbers[array[i], dictionaryDemension] == array[i] && !numbers.ContainsKey(array[i]))
                    {
                        j++;
                        numbers[array[i]] = j;
                    }
                    numbers.Add(array[i], dictionaryDemension);
                }










            }
            foreach (KeyValuePair<int, int> keyValue in numbers)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.ReadKey();
        }





        //for (int i = 0; i < arrayDimension; i++)
        //{
        //   numbers.Add(arr[0], 1);
        //    if (array[i] != array[i+1])
        //    {
        //        if (!numbers.ContainsKey(intValue))
        //        {
        //            numbers.Add(intValue, 0);
        //        }
        //        values[numberOfValues] = Convert.ToInt32(intValue);
        //        numberOfValues++;

        //        numbers[intValue]++;
        //    }
        //    else
        //    {
        //        //Console.WriteLine("Incorrect value.");
        //        //incorrectValues++;

        //    }
        //}
        //foreach (KeyValuePair<int, int> pair in numbers)
        //{
        //    Console.WriteLine("Number {0} occured {1} times.", pair.Key, pair.Value);
        //}



    }
}

