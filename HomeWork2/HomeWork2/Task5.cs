using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Task5
    {


        public static void Task()
        {
            Console.Title = "Анкета";
            Console.Clear();
            Lexx.Utils.OutputHelpers.PrintInfo(2, Menu.number, "Безуглов Алексей");
                     
            Lexx.Utils.OutputHelpers.Heading("Расчет индекса массы тела");

            Console.Write("Введите ваш рост (в сантиметрах)? ");
            string height = Console.ReadLine();

            Console.Write("Введите ваш вес (в килограммах)? ");
            string weight = Console.ReadLine();

            double double_height = double.Parse(height);
            double double_weight = double.Parse(weight);

            double BodyMassIndex = double_weight / Math.Pow((double_height / 100), 2);
            double NormalWeightDown = Math.Round(18 * Math.Pow((double_height / 100), 2),1);
            double NormalWeightUp = Math.Round(25 * Math.Pow((double_height / 100), 2),1);
            double NormalWeigh;

            Console.WriteLine($"\nВаш индекс массы тела равен {Math.Round(BodyMassIndex, 1)}.\n");
           
            if (BodyMassIndex < 16)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("У вас выраженный дефицит массы.");
                NormalWeigh = NormalWeightDown - double_weight;
                Console.WriteLine($"Вам нужно поправиться на {NormalWeigh} килограмм.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (BodyMassIndex >= 16 && BodyMassIndex < 18)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("У вас недостаточная масса тела.");
                NormalWeigh = NormalWeightDown - double_weight;
                Console.WriteLine($"Вам нужно поправиться на {NormalWeigh} килограмм.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (BodyMassIndex >= 18 && BodyMassIndex < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("У вас нормальный вес.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (BodyMassIndex >= 25 && BodyMassIndex < 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("У вас избыточная масса тела.");
                NormalWeigh = double_weight - NormalWeightUp;
                Console.WriteLine($"Вам нужно похудеть на {NormalWeigh} килограмм.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (BodyMassIndex >= 30 && BodyMassIndex < 35)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("У вас ожирение 1 степени.");
                NormalWeigh = double_weight - NormalWeightUp;
                Console.WriteLine($"Вам нужно похудеть на {NormalWeigh} килограмм.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (BodyMassIndex >= 35 && BodyMassIndex < 40)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("У вас ожирение 2 степени.");
                NormalWeigh = double_weight - NormalWeightUp;
                Console.WriteLine($"Вам нужно похудеть на {NormalWeigh} килограмм.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (BodyMassIndex >= 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("У вас ожирение 3 степени.");
                NormalWeigh = double_weight - NormalWeightUp;
                Console.WriteLine($"Вам нужно похудеть на {NormalWeigh} килограмм.");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine("\nНажмите пробел чтобы повторить текущее задание или иную клавишу чтобы выйти в меню");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar) Task();
          

        }



    }
}
