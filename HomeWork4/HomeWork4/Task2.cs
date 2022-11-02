using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class Task2
    {

        public static void Task()
        {
            Console.Title = "Проверка логина и пароля";
            Lexx.Utils.OutputHelpers.PrintInfo(4, Menu.number, "Безуглов Алексей");

            Lexx.Utils.OutputHelpers.Heading("Проверка логина и пароля");

            int counter = 0;
            do
            {
                Console.Write("Введите логин: ");
                var login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                var password = Console.ReadLine();
                counter++;

                string[] LogPas = Lexx.Utils.OutputHelpers.LoadArrayFromFile(AppDomain.CurrentDomain.BaseDirectory + "LogPas.txt");

                for (int i = 0; i < LogPas.Length; i+=2)
                {
                    if (login == LogPas[i] && password == LogPas[i+1])
                    {
                        Console.WriteLine($"Доступ разрешен.\nДобро пожаловать, {LogPas[i]}!\n");
                        goto End;
                    }                    
                }
                Console.WriteLine("\nПара логин/пароль не верны.");
                if (counter < 3)
                {
                    if (3 - counter == 2) Console.WriteLine($"У вас осталось {3 - counter} попытки");
                    if (3 - counter == 1) Console.WriteLine($"У вас осталось {3 - counter} попытка");
                    Console.WriteLine("Повторите попытку.\n");
                }
                else
                {
                    Console.WriteLine("Вы превысили количество попыток.\nДоступ запрещен!!!\n");
                }
            }
            while (counter != 3);
            End:
                        
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
