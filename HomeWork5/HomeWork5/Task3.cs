using Lexx.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Task3
    {
        public static void Task()           // Данный метод не способен определить разницу между "qwwert" и "qweert"
        {

            Console.Title = "Определение перестановки строк";
            OutputHelpers.PrintInfo(5, Menu.number, "Безуглов Алексей");

            OutputHelpers.Heading("Определение перестановки строк");

            Console.Write("Введите первую строку: ");
            string str1 = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string str2 = Console.ReadLine();
            int count = 0;

            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    for (int j = 0; j < str2.Length; j++)
                    {
                        if (str1[i] == str2[j])
                        {
                            count++;
                            //break;
                        }    

                    }   
                }
            }
            Console.WriteLine();
            //Console.WriteLine($"Вы ввели {str1} и {str2}.");

            if (count < str1.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Cтроки не являются перестановкой друг друга");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Cтроки являются перестановкой друг друга");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine("\nНажмите пробел чтобы повторить текущее задание или иную клавишу чтобы выйти в меню");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                Task();
            }
            Console.Clear();
        }
        
    }
}
