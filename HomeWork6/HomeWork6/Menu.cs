using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Menu
    {
        public static int number;

        static void Main(string[] args)
        {

            bool f = true;
            while (f)
            {
                Console.Title = "Домашняя работа 6";
                Lexx.Utils.OutputHelpers.Heading("Домашняя работа 6");
                Console.WriteLine("Меню задач");
                Console.WriteLine("==================================================");
                Console.WriteLine("1 -> Передача функции типа double (double, double)");
                Console.WriteLine("2 -> Программа нахождения минимума функции");
                Console.WriteLine("3 -> Использование коллекций");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("==================================================\n");

                Console.Write("Введите номер задачи: ");

                if (int.TryParse(Console.ReadLine(), out number));
                else { number = -1; }

                switch (number)
                {
                    case 0:
                        f = false;
                        Console.WriteLine("Завершение работы приложения ...");
                        break;

                    case 1:
                        Console.Clear();
                        Task1.Task();
                        break;

                    case 2:
                        Console.Clear();
                        Task2.Task();
                        break;
                    case 3:
                        Console.Clear();
                        Task3.Task();
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный номер задачи.\nПовторите ввод.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }
    }
}
