using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexx.Utils
{
    public class OutputHelpers
    {

        public static void PrintInfo(int homeworkNumber, int taskNumber, string fio)
        {

            string text = $"Домашняя работа {homeworkNumber}. Задание № {taskNumber}";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
            text = $"Студент: {fio}";
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
            text = "Группа: GU_games_3169";
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
            text = new string('=', Console.WindowWidth);
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Heading(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(text);
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(new string('=', text.Length));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static int CheckNumber(string text, ref int number)
        {
            Console.Write(text);
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Некорректный ввод. Необходимо ввести число: ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return number;
        }
       
        public static string CheckLogin(ref string login)
        {
            bool f = true;
            while (f)
            {
                Console.Write("Введите логин: ");
                login = Console.ReadLine();

                if (login.Length < 2 || login.Length > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Логин не может быть менне 2 и более 10 символов. Повторите ввод");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    if (Char.IsDigit(login[0]))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Логин не может начинаться с числа. Повторите ввод");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        for (int i = 0; i < login.Length; i++)
                        {
                            if (!(Char.IsDigit(login[i]) || login[i] >= 'a' && login[i] <= 'z' || login[i] >= 'A' && login[i] <= 'Z'))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Введены недопустимые символы. Используйте буквы латинского алфавита и цифры");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                            else
                            {                                
                                f = false;
                            }
                        }
                    }
                }            
            }
        return login;            
        }
    }
}
