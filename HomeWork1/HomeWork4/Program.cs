using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Вывод данных в центре экрана";
            string Name = "Алексей";
            string Surname = "Безуглов";
            string City = "Мурманск";


            //Console.SetCursorPosition(Console.WindowWidth / 3, Console.WindowHeight / 2);
            //Console.WriteLine($"{Surname} {Name} проживаю в городе {City}");

            //Console.ReadLine();

            Console.Clear();
            OutputHelpers.PrintInCenter($"{Surname} {Name}, г. {City}");
            OutputHelpers.Pause();





        }
    }

    public class OutputHelpers
    {
        public static void PrintInCenter(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.WindowHeight / 2 - 1);
            Console.WriteLine(text);
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
    }



}
