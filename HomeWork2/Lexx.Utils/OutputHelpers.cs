using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
            Console.WriteLine(new string ('=', text.Length));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }



        public static void PrintInCenter(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.WindowHeight / 2 - 1);
            Console.WriteLine(text);
        }

        public static void Pause()
        {
            Console.ReadKey();
        }


        /*public static void ExitBackup(Аргументом должен выступить имя метода)
        {
            Console.WriteLine("Нажмите пробел чтобы повторить текущее задание или иную клавишу чтобы выйти");
                        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Имя метода();

            }

        }
        */


    }
}
