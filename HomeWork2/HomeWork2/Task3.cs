using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Task3
    {
        public static void Task()
        {
            Console.Clear();
            Lexx.Utils.OutputHelpers.PrintInfo(2, Menu.number, "Безуглов Алексей");

            Lexx.Utils.OutputHelpers.Heading("Подсчет суммы всех нечетных положительных чисел");

            Console.WriteLine("Вводите целые числа.\nВвод чисел прекратится если ввести '0'");
            int number;
            int sumNumbers = 0;
            int counter = 1;

            do
            {
                Console.Write($"Введите {counter} число: "); ;
                number = int.Parse(Console.ReadLine());
                counter++;
                if (number > 0 && number % 2 != 0)
                {
                    sumNumbers += number;
                }

            }
            while (number != 0);

            Console.WriteLine($"\nВы ввели {counter - 1} чисел.\nCумма всех нечетных положительных чисел равна {sumNumbers}.\n");
            
            Console.WriteLine("\nНажмите пробел чтобы повторить текущее задание или иную клавишу чтобы выйти в меню");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar) Task();

        }

    }
}
