using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(text);
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(new string('=', text.Length));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static double CheckNumber(string text, ref double number)
        {
            Console.Write(text);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Некорректный ввод. Необходимо ввести число: ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return number;
        }


        //public static double CheckNumber(string text, ref double number)
        //{
        //    bool f = true;
        //    while (f)
        //    {
        //        Console.Write(text);
        //        if (double.TryParse(Console.ReadLine(), out number))
        //        {
        //            f = false;
        //        }
        //        else
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("Некорректный ввод. Необходимо вводить число.");
        //            Console.ForegroundColor = ConsoleColor.White;
        //        }
        //    }
        //    return number;
        //}

        public static double CheckNumberDontNull(string text, ref double number)
        {
            bool f = true;
            while (f)
            {
                Console.Write(text);
                if (double.TryParse(Console.ReadLine(), out number))
                {
                    if (number != 0)
                    {
                        f = false;
                    }
                    else
                    { 
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный ввод. На ноль делить нельзя.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректный ввод. Необходимо вводить число.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return number;
        }






        //public void CheckDouble(double number,  method)
        //{
        //    if (double.TryParse(Console.ReadLine(), out number))
        //    { }
        //    else
        //    {
        //        Console.Clear();
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Некорректный ввод.\n");
        //        Console.ForegroundColor = ConsoleColor.White;
        //        method();
        //    }


        //}



    }
}
