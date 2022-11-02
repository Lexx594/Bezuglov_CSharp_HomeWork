using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Task2
    {
        public static int count;
        public static void Task()
        {
            Console.Clear();
            Lexx.Utils.OutputHelpers.PrintInfo(2, Menu.number, "Безуглов Алексей");

            Lexx.Utils.OutputHelpers.Heading("Подсчет количества цифр числа");
            
            Console.Write("Введите любое целое число: ");
            GetCountOfDigitsOfNumber(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Количество цифр в числе: {count}\n");



            //Console.Write("Введите любое целое число: ");
            //var number = Console.ReadLine();
            /*
            int LenNumber = number.Length;
            if (int.Parse(number) < 0)
            {
                LenNumber = number.Length - 1;
            }
            */
            //int LenNumber = int.Parse(number) < 0 ? number.Length - 1 : number.Length;   // В виде тернарнарной операции

            //Console.WriteLine($"Количество цифр в числе: {LenNumber}\n");

            Console.WriteLine("\nНажмите пробел чтобы повторить текущее задание или иную клавишу чтобы выйти в меню");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar) Task();



        }

        static int GetCountOfDigitsOfNumber(int number)
        {
            // Если число равно 0, результат подсчета 1, завершаем работу метода
            count = (number == 0) ? 1 : 0;
            // Если число не равно 0, мы переходим в цикл while с пред. условием
            while (number != 0) // Цикл будет работать до тех пор, пока значение числа не будет равно 0
            {
                count++; // Кол-во цифр +1 (у числа существует как минимум 1 разряд)
                number /= 10; // Делим число на 10, избавляемся от очередного разряда числа
            }
            return count; // Возвращаем кол-во цифр числа
        }


    }
}
