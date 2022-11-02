using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Task4
    {
        public static void Task()
        {
            Console.Clear();
            Lexx.Utils.OutputHelpers.PrintInfo(2, Menu.number, "Безуглов Алексей");

            Lexx.Utils.OutputHelpers.Heading("Проверка логина и пароля");

            bool access;
            int counter = 0;
            do
            {
                Console.Write("Введите логин: ");
                var login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                var password = Console.ReadLine();
                counter++;
                if (login == "root" && password == "GeekBrains")
                {
                    Console.WriteLine("Доступ разрешен.\nДобро пожаловать!\n");
                    access = true;
                    break;
                    //goto M; //это я просто эксперементировал

                }
                else
                {
                    Console.WriteLine("\nПара логин/пароль не верны.");
                    
                    if (counter < 3)
                    {
                        if (3 - counter == 2) Console.WriteLine($"У вас осталось {3 - counter} попытки");
                        if (3 - counter == 1) Console.WriteLine($"У вас осталось {3 - counter} попытка");
                        Console.WriteLine("Повторите попытку.\n");
                    }
                    else
                    {
                        access = false;
                        Console.WriteLine("Вы превысили количество попыток.\nДоступ запрещен!!!\n");
                    }
                }
                
            }
            while (counter != 3);

            //M:


            Console.WriteLine("\nНажмите пробел чтобы повторить текущее задание или иную клавишу чтобы выйти в меню");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar) Task();


        }


    }
}
