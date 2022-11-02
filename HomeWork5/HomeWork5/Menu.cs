using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Menu
    {

        public static int number;

        static void Main(string[] args)
        {

            bool f = true;
            while (f)
            {
                Console.Title = "Домашняя работа 5";
                Lexx.Utils.OutputHelpers.Heading("Домашняя работа 5");
                Console.WriteLine("Меню задач");
                Console.WriteLine("=======================================");
                Console.WriteLine("1 -> Проверка корректности ввода логина");
                Console.WriteLine("2 -> Методы класса Message");
                Console.WriteLine("3 -> Определение перестановки строк");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("=======================================\n");

                Console.Write("Введите номер задачи: ");

                if (int.TryParse(Console.ReadLine(), out number)) ;
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
                    case 4:
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
