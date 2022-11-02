using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lexx.Utils;

namespace HomeWork4
{
    internal class Task1
    {

        public static void Task()
        {

            bool f = true;

            while (f)
            {
                Console.Title = "Работа с массивом";
                OutputHelpers.PrintInfo(4, Menu.number, "Безуглов Алексей");

                OutputHelpers.Heading("Работа с массивом");

                Console.WriteLine("Меню задания № 1");
                Console.WriteLine("=========================================================");
                Console.WriteLine("1 -> Создание массива и его заполнение");
                Console.WriteLine("2 -> Подсчитываем сумму элементов массива");
                Console.WriteLine("3 -> Изменяем знаки у всех элементов массива");
                Console.WriteLine("4 -> Умножение каждого элемента массива на заданное число");
                Console.WriteLine("5 -> Определение количества максимальных элементов");
                Console.WriteLine("0 -> Возвращение в меню задач");
                Console.WriteLine("=========================================================\n");

                Console.Write("Введите номер задания: ");
                int taskNumber;
                if (int.TryParse(Console.ReadLine(), out taskNumber)) { }
                else {taskNumber = 10;}

                switch (taskNumber)
                {
                    case 0:
                        f = false;
                        Console.Clear();
                        break;

                    case 1:
                        Console.Clear();
                        Task11();
                        break;

                    case 2:
                        Console.Clear();
                        Task12();
                        break;

                    case 3:
                        Console.Clear();
                        Task13();
                        break;

                    case 4:
                        Console.Clear();
                        Task14();
                        break;

                    case 5:
                        Console.Clear();
                        Task15();
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный номер задания.\nПовторите ввод.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

            }

        }

        static void Task11()
        {
            OutputHelpers.Heading("Создание массива и его заполнение");
            int sizeArr = 0;
            int firstNumber = 0;
            int step = 0;

            OutputHelpers.CheckNumber("Задайте размер массива: ", ref sizeArr);
            OutputHelpers.CheckNumber("Задайте начальное значение: ", ref firstNumber);
            OutputHelpers.CheckNumber("Задайте шаг заполнения массива: ", ref step);
            Console.WriteLine();
            MyArray myArray1 = new MyArray(sizeArr, firstNumber, step);
            Console.WriteLine("Массив по заданным параметрам:");
            myArray1.PrintArray();

            Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                Task11();
            }
            Console.Clear();
        }

        static void Task12()
        {
            OutputHelpers.Heading("Подсчитываем сумму элементов массива");
            int sizeArr = 0;
            OutputHelpers.CheckNumber("Массив заполнится случайными числа автоматически.\nЗадайте размер массива: ", ref sizeArr);
            Console.WriteLine();
            MyArray myArray2 = new MyArray(sizeArr);
            Console.WriteLine("Массив по заданным параметрам:");
            myArray2.PrintArray();
            Console.WriteLine();
            int sumArray = myArray2.Sum();
            Console.WriteLine($"Сумма всех элементов массива равна {sumArray}");

            Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                Task12();
            }
            Console.Clear();
        }

        static void Task13()
        {
            OutputHelpers.Heading("Изменяем знаки у всех элементов массива");
            int sizeArr = 0;
            OutputHelpers.CheckNumber("Массив заполнится случайными числа автоматически.\nЗадайте размер массива: ", ref sizeArr);
            Console.WriteLine();
            MyArray myArray3 = new MyArray(sizeArr);
            Console.WriteLine("Сформированный массив по заданным параметрам:");
            myArray3.PrintArray();
            Console.WriteLine();
            int[] newArray = myArray3.InverseNewArr();
            MyArray myArray5 = new MyArray(newArray);
            Console.WriteLine("Инвентированный массив:");
            myArray5.PrintArray();

            Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                Task13();
            }
            Console.Clear();
        }

        static void Task14()
        {
            OutputHelpers.Heading("Умножение каждого элемента массива на заданное число");
            int sizeArr = 0;
            int number = 0;
            OutputHelpers.CheckNumber("Массив заполнится случайными числа автоматически.\nЗадайте размер массива: ", ref sizeArr);
            OutputHelpers.CheckNumber("Задайте число на корое умножить каждый элеммент массива: ", ref number);
            Console.WriteLine();
            MyArray myArray4 = new MyArray(sizeArr);
            Console.WriteLine("Сформированный массив по заданным параметрам:");
            myArray4.PrintArray();
            Console.WriteLine();
            myArray4.Multi(number);
            Console.WriteLine("Массив после умножения на заданное число:");
            myArray4.PrintArray();

            Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                Task14();
            }
            Console.Clear();
        }

        static void Task15()
        {
            OutputHelpers.Heading("Определение количества максимальных элементов");
            int sizeArr = 0;
            OutputHelpers.CheckNumber("Массив заполнится случайными числа автоматически.\nЗадайте размер массива: ", ref sizeArr);
            Console.WriteLine();
            MyArray myArray5 = new MyArray(sizeArr);
            Console.WriteLine("Сформированный массив по заданным параметрам:");
            myArray5.PrintArray();
            Console.WriteLine();
            string count;
            int maxN = myArray5.Max;
            
            Console.WriteLine($"Максимальное значение элементов массива равно {maxN}");
            int maxCount = myArray5.MaxCount;
            if (maxCount >= 2 && maxCount <= 4) count = "раза";
            else count = "раз";
            Console.WriteLine($"Максимальное значение повторяется {maxCount} {count}");

            Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                Task15();
            }
            Console.Clear();
        }

    }

}
