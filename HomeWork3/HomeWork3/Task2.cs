using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Task2
    {

        public static void Task()
        {
            bool f = true;

            while (f)
            {
                //Console.Clear();
                Lexx.Utils.OutputHelpers.PrintInfo(3, Menu.number, "Безуглов Алексей");

                Lexx.Utils.OutputHelpers.Heading("Работа с классом Complex");

                Console.WriteLine("Меню задания № 2");
                Console.WriteLine("====================================================");
                Console.WriteLine("1 -> Сложение комплексных чисел классом Complex");
                Console.WriteLine("2 -> Вычитания комплексных чисел классом Complex");
                Console.WriteLine("3 -> Умножение комплексных чисел классом Complex");
                Console.WriteLine("4 -> Деление комплексных чисел классом Complex");
                Console.WriteLine("0 -> Возвращение в меню задач");
                Console.WriteLine("====================================================\n");

                Console.Write("Введите номер задания: ");
                int taskNumber;
                if (int.TryParse(Console.ReadLine(), out taskNumber))
                { }
                else
                {
                    taskNumber = 10;
                }

                switch (taskNumber)
                {
                    case 0:
                        f = false;
                        Console.Clear();
                        break;

                    case 1:
                        Console.Clear();
                        classComplexPlus();
                        break;

                    case 2:
                        Console.Clear();
                        classComplexMinus();
                        break;

                    case 3:
                        Console.Clear();
                        classComplexMultiplication();
                        break;

                    case 4:
                        Console.Clear();
                        classComplexDivision();
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный номер задания.\nПовторите ввод.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

            }

        }

        public static void classComplexPlus()
        {

            Lexx.Utils.OutputHelpers.Heading("Сложение комплексных чисел классом Complex");

            double reComp1 = 1, imComp1 = 1;
            double reComp2 = 1, imComp2 = 1;


            Lexx.Utils.OutputHelpers.CheckNumber("Введите действительную часть первого комплексно числа: ", ref reComp1);
            Lexx.Utils.OutputHelpers.CheckNumber("Введите мнимую часть первого комплексно числа: ", ref imComp1);

            ComplexClass complex1 = new ComplexClass(reComp1, imComp1);

            Lexx.Utils.OutputHelpers.CheckNumber("Введите действительную часть второго комплексно числа: ", ref reComp2);
            Lexx.Utils.OutputHelpers.CheckNumber("Введите мнимую часть второго комплексно числа: ", ref imComp2);
                     
            ComplexClass complex2 = new ComplexClass(reComp2, imComp2);

            ComplexClass complex3 = complex1.Plus(complex2);

            Console.WriteLine($"Результат сложения заданных комплексных чисел {complex1} и {complex2} равен {complex3}");


            Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                classComplexPlus();
            }
            Console.Clear(); 

        }

        public static void classComplexMinus()
        {

            Lexx.Utils.OutputHelpers.Heading("Вычитание комплексных чисел классом Complex");

            double reComp1 = 1, imComp1 = 1;
            double reComp2 = 1, imComp2 = 1;


            Lexx.Utils.OutputHelpers.CheckNumber("Введите действительную часть первого комплексно числа: ", ref reComp1);
            Lexx.Utils.OutputHelpers.CheckNumber("Введите мнимую часть первого комплексно числа: ", ref imComp1);

            ComplexClass complex1 = new ComplexClass(reComp1, imComp1);

            Lexx.Utils.OutputHelpers.CheckNumber("Введите действительную часть второго комплексно числа: ", ref reComp2);
            Lexx.Utils.OutputHelpers.CheckNumber("Введите мнимую часть второго комплексно числа: ", ref imComp2);

            ComplexClass complex2 = new ComplexClass(reComp2, imComp2);

            ComplexClass complex3 = complex1.Plus(complex2);

            Console.WriteLine($"Результат вычитания комплексного чисела {complex2} из комплексного числа {complex1} равен {complex3}");


            Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                classComplexMinus();
            }
            Console.Clear();

        }

        public static void classComplexMultiplication()
        {

            Lexx.Utils.OutputHelpers.Heading("Умножение комплексных чисел классом Complex");

            double reComp1 = 1, imComp1 = 1;
            double reComp2 = 1, imComp2 = 1;


            Lexx.Utils.OutputHelpers.CheckNumber("Введите действительную часть первого комплексно числа: ", ref reComp1);
            Lexx.Utils.OutputHelpers.CheckNumber("Введите мнимую часть первого комплексно числа: ", ref imComp1);

            ComplexClass complex1 = new ComplexClass(reComp1, imComp1);

            Lexx.Utils.OutputHelpers.CheckNumber("Введите действительную часть второго комплексно числа: ", ref reComp2);
            Lexx.Utils.OutputHelpers.CheckNumber("Введите мнимую часть второго комплексно числа: ", ref imComp2);

            ComplexClass complex2 = new ComplexClass(reComp2, imComp2);

            ComplexClass complex3 = complex1.Multiplication(complex2);

            Console.WriteLine($"Результат умножения заданных комплексных чисел {complex1} и {complex2} равен {complex3}");


            Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                classComplexMultiplication();
            }
            Console.Clear();

        }

        public static void classComplexDivision()
        {

            Lexx.Utils.OutputHelpers.Heading("Деление комплексных чисел классом Complex");

            double reComp1 = 1, imComp1 = 1;
            double reComp2 = 1, imComp2 = 1;


            Lexx.Utils.OutputHelpers.CheckNumber("Введите действительную часть делимого комплексно числа: ", ref reComp1);
            Lexx.Utils.OutputHelpers.CheckNumber("Введите мнимую часть делимого комплексно числа: ", ref imComp1);

            ComplexClass complex1 = new ComplexClass(reComp1, imComp1);

            Lexx.Utils.OutputHelpers.CheckNumberDontNull("Введите действительную часть делителя комплексно числа: ", ref reComp2);
            Lexx.Utils.OutputHelpers.CheckNumberDontNull("Введите мнимую часть делителя комплексно числа: ", ref imComp2);
            
            ComplexClass complex2 = new ComplexClass(reComp2, imComp2);

            ComplexClass complex3 = complex1.Division(complex2);

            Console.WriteLine($"Результат умножения заданных комплексных чисел {complex1} и {complex2} равен {complex3}");

            Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                classComplexDivision();
            }
            Console.Clear();

        }

    }


    class ComplexClass
    {

        public double re;      //действительная часть комплексного числа
        public double im;      //Мнимая часть комплексного числа

        public ComplexClass(double re, double im)   //Конструктор который позволит сразу проинициализировать переменные re т im
        {
            this.re = re;
            this.im = im;
        }

        public override string ToString() //Переопределяем метод работы ToString (т.е. в каком виде нам покажут в консоле переменную Complex)
        {
            
            return $"{re.ToString("F2", CultureInfo.InvariantCulture)} + {im.ToString("F2", CultureInfo.InvariantCulture)}i";
        }

        public ComplexClass Plus(ComplexClass x)
        {
            ComplexClass complexRes = new ComplexClass(re + x.re, im + x.im); // Такая запись стала возможна благодаря созданому нами конструктору
            //complexRes.re = re + x.re;
            //complexRes.im = im + x.im;
            return complexRes;
        }

        public ComplexClass Minus(ComplexClass x)
        {
            ComplexClass complexRes = new ComplexClass(re - x.re, im - x.im);
            return complexRes;
        }

        public ComplexClass Multiplication(ComplexClass x)
        {
            ComplexClass complexRes = new ComplexClass(re * x.re, im * x.im);
            return complexRes;
        }

        public ComplexClass Division(ComplexClass x)
        {
            ComplexClass complexRes = new ComplexClass(re / x.re, im / x.im);
            return complexRes;
        }

    }

}







    
