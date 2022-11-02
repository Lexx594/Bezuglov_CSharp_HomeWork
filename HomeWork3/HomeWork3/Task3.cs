using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
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
                Console.Write($"Введите {counter} число: ");

                if (int.TryParse(Console.ReadLine(), out number)) ;

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректный ввод! Необходимо вводить число.");
                    Console.ForegroundColor = ConsoleColor.White;
                    number = 1;
                    continue;
                }
                    
                counter++;
                if (number > 0 && number % 2 != 0)
                {
                    sumNumbers += number;
                    Console.WriteLine($"Сумма введенных нечетных положительных чисел равна {sumNumbers}");
                }

            }
            while (number != 0);

            Console.WriteLine($"\nВы ввели {counter - 1} чисел.\nCумма всех нечетных положительных чисел равна {sumNumbers}.\n");

            Console.WriteLine("\nНажмите пробел чтобы повторить текущее задание или иную клавишу чтобы выйти в меню");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar) Task();
            Console.Clear();

        }
        // Эта версия решения предложена преподавателем

        public static void Task1()
        {
            Console.Clear();

            Console.Title = "Работа с числами";
            Console.WriteLine("Вводите числа (0 - завершение работы приложения):");
            int number, sum = 0; // Объявим две вспомогательные переменные для хранения текущего значения введенного числа и суммы искомых чисел
            do // Воспользуемся циклом while  с предусловием
            {
                Console.Write($"Введите число:");
                if (int.TryParse(Console.ReadLine(), out number)) // Используя конструкцию TryParse введем число с клавиатуры, проверим число на корректность ввода
                {
                    sum += Sum(number); // Если число задано корректно, сложим его с общей суммой, но для начала проверим его через метод Sum
                }
                else
                {
                    // Число введено некорректно, сообщим об этом пользователю, продолжим работу дальше
                    Console.WriteLine("Вы ввели некорректное число, повторите ввод.");
                    number = -1;
                }

            } while (number != 0); // Цикл будет выполняться до тех пор, пока мы не введем корректное значение равное нулю

            // Вот и все, выводим результат работы программы
            Console.WriteLine($"Сумма всех положительных, нечетных чисел: {sum}");
            Console.ReadLine();

        }

        /// <summary>
        /// Метод проверки числа.
        /// Число должно быть положительное, нечетное
        /// </summary>
        /// <param name="x">Число для проверки</param>
        /// <returns>Результат проверки числа</returns>
        static int Sum(int x)
        {
            return (x > 0 && x % 2 != 0) ? x : 0;
        }




    }


}
