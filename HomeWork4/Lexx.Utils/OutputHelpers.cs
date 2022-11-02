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
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
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
        public static string[] LoadArrayFromFile(string fileName) 
        {
            if (File.Exists(fileName))     //Здесь потребовалось выбрать к чему относится класс File
            {
                StreamReader streamReader = new StreamReader(fileName);
                string[] buf = new string[1000];
                int count = 0;
                while (!streamReader.EndOfStream)
                {
                    buf[count] = streamReader.ReadLine();
                    count++;
                }
                string[] arr = new string[count];     //создаем новый массив с разменостью длины предыдущего массива
                Array.Copy(buf, arr, count); // копируем массив в массив
                streamReader.Close();   //Закрываем поток установленный с файлом
                return arr;
            }
            else
                throw new FileNotFoundException();
        }


    }
}
