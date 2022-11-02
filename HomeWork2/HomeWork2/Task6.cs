using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Task6
    {
        public static void Task()
        {
            Console.Clear();
            Lexx.Utils.OutputHelpers.PrintInfo(2, Menu.number, "Безуглов Алексей");

            Lexx.Utils.OutputHelpers.Heading("Подсчет 'хороших' чисел");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Внимание! На подсчет в диапозоне от 1 до 1000000000 в среднем уходит 30 минут");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nНажмите Enter чтобы вернуться в меню или иную клавишу для продолжения");
            if (Console.ReadKey().Key == ConsoleKey.Enter) goto End;


            var DateBefore = DateTime.Now;
            int count = 0;
            for (int i = 1; i <1000000000; i++)
            {
                int number = i;
                int sumNumbers = 0;
                while (number > 0)
                {
                    var digit = number % 10;
                    number /= 10;
                    sumNumbers = sumNumbers + digit;
                }
                if (i % sumNumbers == 0)
                {
                    Console.WriteLine(i);
                    count++;
                }

            }
            Console.WriteLine($"\nВсего в заданном диапазоне {count} 'хороших' чисел");

              
            TimeSpan timeSpan = DateTime.Now - DateBefore;

            Console.WriteLine($"\nНа подсчет 'хороших' чисел затрачено {timeSpan} времени");

            
            Console.WriteLine("\nНажмите пробел чтобы повторить текущее задание или иную клавишу чтобы выйти в меню");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar) Task();
            End:;
            

            /* Этот код был взят из стороннего источника и был использован как образец для перебора цифр числа
             
            int divisor = 10;
            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number>0)
            {
                var digit = number % divisor;
                number /= 10;
                Console.WriteLine(digit);
            }
            Console.ReadLine();
            
            */


            



        }

    }
}
