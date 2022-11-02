using Lexx.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{

    public delegate double Fun(double x, double y);

    internal class Task1
    {

        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, b));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double Degree(double a, double b)
        {
            //Console.Write($"{a} * {b}^2");
            return a * Math.Pow(b, 2);
        }
        public static double Sin(double a, double b)
        {
            //Console.Write($"{a} * Sin({b})");
            return a * Math.Sin(b);
        }

        public static void Task()
        {

            bool f = true;

            while (f)
            {
                Console.Title = "Передача функции типа double (double, double)";
                OutputHelpers.PrintInfo(6, Menu.number, "Безуглов Алексей");

                OutputHelpers.Heading("Передача функции типа double (double, double)");

                Console.WriteLine("Меню задания № 1");
                Console.WriteLine("=========================================================");
                Console.WriteLine("1 -> C функцией a*x^2");
                Console.WriteLine("2 -> C функцией a*sin(x)");
                Console.WriteLine("0 -> Возвращение в меню задач");
                Console.WriteLine("=========================================================\n");

                Console.Write("Введите номер задания: ");
                int taskNumber;
                if (int.TryParse(Console.ReadLine(), out taskNumber)) { }
                else { taskNumber = 10; }

                switch (taskNumber)
                {
                    case 0:
                        f = false;
                        Console.Clear();
                        break;

                    case 1:
                        Console.Clear();
                        Task11();
                        break;

                    case 2:
                        Console.Clear();
                        Task12();
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

        public static void Task11()
        {
            OutputHelpers.Heading("C функцией a*x^2");
            Table(new Fun(Degree), -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            Table(Degree, -2, 2);
            Console.WriteLine("Еще раз но с анонимным методом");
            Table(delegate (double a, double b)
            {
                //Console.Write($"{a} * Sin({b})");
                return a * Math.Pow(b, 2);
            }, -2, 2);
            Console.WriteLine("Еще раз с лямбда выражением");
            Table((b, a) => a * Math.Pow(b, 2), -2, 2);


            Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                Task11();
            }
            Console.Clear();
        }

        public static void Task12()
        {
            OutputHelpers.Heading("C функцией a*sin(x)");
            Table(new Fun(Sin), -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            Table(Sin, -2, 2);
            Console.WriteLine("Еще раз но с анонимным методом");
            Table(delegate (double a, double b)
            {
                //Console.Write($"{a} * Sin({b})");
                return a * Math.Sin(b);
            }, -2, 2);
            Console.WriteLine("Еще раз с лямбда выражением");
            Table((b, a) => a * Math.Sin(b), -2, 2);

            Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                Task12();
            }
            Console.Clear();
        }
    }     
}
