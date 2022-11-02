using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Menu
    {

        public static int number;

        public static void Main(string[] args)
        {
            Console.Title = "Домашняя работа 3";


            bool f = true;

            while (f)
            {
                //Console.Clear();
                Console.WriteLine("Меню задач");
                Console.WriteLine("====================================================");
                Console.WriteLine("1 -> Работа с структурой Complex");
                Console.WriteLine("2 -> Работа с классом Complex");
                Console.WriteLine("3 -> Подсчет суммы всех нечетных положительных чисел");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("====================================================\n");

                Console.Write("Введите номер задачи: ");


                if (int.TryParse(Console.ReadLine(), out number));
                else { number = 10; }
                                

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
