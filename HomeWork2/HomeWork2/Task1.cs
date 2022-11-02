using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Task1
    {


        public static void Task()
        {
            Console.Clear();
            Lexx.Utils.OutputHelpers.PrintInfo(2, Menu.number, "Безуглов Алексей");

            Lexx.Utils.OutputHelpers.Heading("Сравнение трех чисел");

            Console.Write("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine());
            
            Console.Write("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());
            
            Console.Write("Введите третье число: ");
            int number3 = int.Parse(Console.ReadLine());

            int minNumber;

            if (number1 < number2 && number1 < number3)
            {
                minNumber = number1;
                            
            }    
            else if (number2 < number1 && number2 < number3)
                minNumber = number2;

            else
                minNumber = number3;

            Console.WriteLine($"Наименьшее число {minNumber}\n");

            Console.WriteLine("\nНажмите пробел чтобы повторить текущее задание или иную клавишу чтобы выйти в меню");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar) Task();


        }


    }
}
