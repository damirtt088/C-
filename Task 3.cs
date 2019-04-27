﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Drob                              // Почему определяется как "class Lesson_3.Drob"
    {
        static int Chislit;                //Это поля или переменные? Или это одно и тоже? Есть четкая терминология? 
        static int Znamenat;

        public Drob() { }                   //Для чего это необходимо? VS Требует это и предлагает сделать. После создания этого (Это метод?) ушло много ошибок, детектируемых VS-ом.

        public Drob(int chisl, int znam)  //Это переопределние переменных необходимо для того чтобы отделить свойства (ниже) и поля? 
        {
            Chislit = Chisl;
            Znamenat = Znam;
        }

        public int Chisl                  //Это свойство? Во многих статьях и объяснениях программ и т.д. и т.п. "в сети" говорится что свойства и поля (переменные?) это почти одно и то же Как это может быть? 
        {
            get { return Chislit; }
            set { Chislit = value; }
        }

        public int Znam                  // Это свойство?
        {
            get { return Znamenat; }
            set
            {
                if (Znamenat == 0)
                    throw new ArgumentException(nameof(Znam) + " cannot be 0", nameof(Znam)); //Здесь мы "ловим" возможную ошибку. Задаем свойство, что знаменатель не может быть равен нулю. Это правильно?
                Znamenat = value;
            }
        }
        public static Drob Plus(Drob drob1, Drob drob2)  // Это метод. Он является обязательным атрибутом класса?  Если обозначаем его как "public" Значит он должен быть виден и в других классах или нет?
        {
            Drob dr = new Drob();                 //Создаем новый экземпляр дроби из класса Drob. Он работает ТОЛЬКО внутри этого метода? 

            if (drob1.Znam != drob2.Znam)
            {
                dr.Chisl = drob1.Chisl * drob2.Znam + drob2.Chisl * drob1.Znam;
                dr.Znam = drob1.Znam * drob2.Znam;
            }
            else
            {
                dr.Chisl = drob1.Chisl + drob2.Chisl;
                dr.Znam = drob1.Znam;
            }
            return dr;
        }
        public static Drob Minus(Drob drob1, Drob drob2)
        {
            Drob dr = new Drob();

            if (drob1.Znam != drob2.Znam)
            {
                dr.Chisl = drob1.Chisl * drob2.Znam - drob2.Chisl * drob1.Znam;
                dr.Znam = drob1.Znam * drob2.Znam;
            }
            else
            {
                dr.Chisl = drob1.Chisl - drob2.Chisl;
                dr.Znam = drob1.Znam;
            }
            return dr;
        }

        public static Drob Multiplication(Drob drob1, Drob drob2)
        {
            Drob dr = new Drob();
            dr.Chisl = drob1.Chisl * drob2.Chisl;
            dr.Znam = drob1.Znam * drob2.Znam;
            return dr;
        }

        public static Drob Divisionn(Drob drob1, Drob drob2)
        {
            Drob dr = new Drob();
            dr.Chisl = drob1.Chisl * drob2.Znam;
            dr.Znam = drob1.Znam * drob2.Chisl;
            return dr;
        }

        public void Reduce(ref int Chisl, ref int Znam)
        {
            for (int i = 2; i < Math.Max(Chisl, Znam); i++)
            {
                if (Chisl % i == 0 && Znam % i == 0)
                {
                    Chisl /= i;
                    Znam /= i;
                    i = 1;
                }
            }
        }

        public static string ToString()
        {
            return (Drob.Chislit + "/" + Drob.Znamenat);
        }

        public static string ReadNumberForDrob(int a)
        {
            a = Convert.ToInt32(Console.ReadLine());
            return a;                                 //Здесь имеем ошибку "Ошибка CS0029  Не удается неявно преобразовать тип "string" в "int"." Но мы же используем явное преобразование Convert.ToInt32. Что не так?
        }


        // Если здесь написать "class Program", то мы перестаем видеть методы класса Drobe (мы вышли из тела метода "наружу"). Как выйти из положения? Или можно вообще не использовать "class Program"  для решения данной задачи? 

        static void Main(string[] args)
        {
            Drob dr1 = new Drob();
            Console.WriteLine("Введите числитель первой дроби");
            Chislit = ReadNumberForDrob(a);                      //Выдает ошибку "Ошибка CS0103  Имя "a" не существует в текущем контексте.". Но если двумя строками выше определить переменную как " int a;", то получаем "Ошибка CS0029  Не удается неявно преобразовать тип "string" в "int"." 
                                                                 //Как правильно считать по отдельности данные для двух дробей? 
                                                                 //Можно было бы конечно сделать проще и задать явно и один раз  Drob dr = new Drob(1,2), хочется понять как сделать хорошо (не красиво, а хорошо). 
            Console.WriteLine("Введите знаменатель первой дроби");
            Znamenat = ReadNumberForDrob(a);
            Console.WriteLine($"Первая дробь {Drob.ToString()}");

            Drob dr2 = new Drob();
            Console.WriteLine("Введите числитель второй дроби");
            Chislit = ReadNumberForDrob(a);
            Console.WriteLine("Введите знаменатель второй дроби");
            Znamenat = ReadNumberForDrob(a);
            Console.WriteLine($"Вторая дробь {Drob.ToString()}");


            int Summa = Drob.Plus(dr1, dr2); // Ошибка CS0029  Не удается неявно преобразовать тип "Lesson_3.Drob" в "int".Lesson 3  

            int Razn = Drob.Minus(dr1, dr2);

            

        }

    }
}


//  Математическое решение данной задачи труда не представляет абсолютно. У меня сын пятикласник ее делает. А вот решение данной задачи с точки зрения синтаксиса C# представляет определенную трудность, в задании четко сказано "*Описать класс дробей". Задание пришлось сдать в таком виде, 
//  чтобы было понятно, что не понятно (изините за тавтологию) и чтобы показать, что все заданные вопросы не написаны просто так, а пришли в ходе разбора темы и попытке дать решение.  
//     Не понятно 
//  1. Какие атрибуты имеет класс. 
//  2. Какие из них обязательны, а какие могут браться и берутся в контексте решения конкретной задачи? 
//  3. Что такое переменные в контексте использования в "классах". Это тоже самое как и обычно в программировании(велечина которой может 
//     присваиваться определенное значение для использования в дальнейших вычислениях. Переменной можно переприсваивать значени взависимости от структуры программы)? Или есть определенная "фишка" в контексте использования ее в "классе"?
//  4. Что такое поля и как они связаны с перменными?
//  5. Свойства. Что это и как они связаны с переменными и полями? https://ru.stackoverflow.com/questions/56128/Для-чего-нужны-get-и-set , https://ru.stackoverflow.com/questions/197067/Для-чего-нужны-свойства?noredirect=1&lq=1 Это верно?
//     Вы говорили о возможности проведения дополнительного задания - т.к. понимая, что данная тема является "краеугольным" камнем всего ООП в принципе и C# в частности - Это возможно?
//  1. Сколько это стоит в денежном эквиваленте?
//  2. Когда ВАМ удобно?
//  3. Все таки еще раз спрошу (уже получив ваш ответ во время урока, что больше нужно программировать) Есть ли где-то (неважно в сети или в бумажном варианте) четкое и полное описание понятия "класс" в контексте ООП. В тех книгах, которые вы рекомендовали в самом начале этого нет. 
//     Все "размыто и "размазано". Во всяком случае в русском варианте "Изучаем C#. Э. Стиллмен, Дж. Грин" и английском "Язык программирования C# 6.0 и платформа .NET 4.6. Эндрю Троелсен, Филипп Джепикс" (русского варианта для скачивания в сети я не нашел, а в ангийском именно для 
//     программирования я не особо силен. Моя область работы далека от программирования (неразрушающий контроль)) я не смог ЧЕТКО и ЯСНО "вычленить" эти вопросы. А ребенку, для которого куплен этот курс, объяснять надо.
//     Я понимаю, что вы НЕ ДОЛЖНЫ и НЕ ОБЯЗАНЫ все это объяснять, но если есть у вас такая возможность (тем более ваши знания в этой области профессиональны) хотелось бы получить все эти объяснения. 
//     Особенно так, как объясняете вы - с разбором конкретных примеров (Может на этом примере и разберем?).
//     И еще одно пожелание (я уже писал в отзыве к уроку. Я смотрю уроки вместе с сыноми и по ходу или потом объясняю, что ему пока не понятно ) - на курсе есть 3-4 человека, которые "срывают" вам урок. Они уже имеют какое-то образование в программировании (им это неинтересно и уже понятно) и 
//     "уводят" вас от объяснения по теме "C# УРОВЕЬ 1". Вы уже пытались "поставить их на место" в 1 уроке - они это не поняли.  На курс пришли люди для постижения "азов" и основ языка. Ваши объяснения понятны и "хороши", но, из-за этих студентов, рваные. 
//     Возможно я во всем вышенаписанном и не прав, в таком случае прошу прощения.
//     Папа Дамира Мухаметшина - Рустем Мухаметшин (на сайте GeekBrains аккаунт есть). Заранее спасибо за любой ваш ответ, уделенное время и уроки.