using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Menu
    {
        public static int number;

        static void Main(string[] args)
        {
            Console.Title = "Домашняя работа 2";


            bool f = true;

            while (f)
            {
                Console.Clear();
                Console.WriteLine("Меню задач");
                Console.WriteLine("====================================================");
                Console.WriteLine("1 -> Сравнение трех чисел");
                Console.WriteLine("2 -> Подсчет количества цифр числа");
                Console.WriteLine("3 -> Подсчет суммы всех нечетных положительных чисел");
                Console.WriteLine("4 -> Проверка логина и пароля");
                Console.WriteLine("5 -> Расчет индекса массы тела");
                Console.WriteLine("6 -> Подсчет 'хороших' чисел");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("====================================================\n");

                Console.Write("Введите номер задачи: ");
                number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 0:
                        f = false;
                        Console.WriteLine("Завершение работы приложения ...");
                        break;
                                        
                    case 1:
                        Task1.Task();
                        break;

                    case 2:
                        Task2.Task();
                        break;

                    case 3:
                        Task3.Task();
                        break;

                    case 4:
                        Task4.Task();
                        break;

                    case 5:
                        Task5.Task();
                        break;

                    case 6:
                        Task6.Task();
                        break;

                    default:
                        Console.WriteLine("Некорректный номер задачи.\nПовторите ввод.");
                        break;
                }
            }

        }
               

    }
}
