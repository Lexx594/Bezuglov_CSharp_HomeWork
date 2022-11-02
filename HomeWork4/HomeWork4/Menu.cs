using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lexx.Utils;

namespace HomeWork4
{
    internal class Menu
    {

        public static int number;

        static void Main(string[] args)
        {
            bool f = true;
            while (f)
            {
                Console.Title = "Домашняя работа 4";
                Console.WriteLine("Меню задач");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Работа с массивом");
                Console.WriteLine("2 -> Работа с логинамии паролями");
                Console.WriteLine("3 -> Создание аккаунта");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("=================================\n");

                Console.Write("Введите номер задачи: ");

                if (int.TryParse(Console.ReadLine(), out number)) ;
                else { number = 10; }

                switch (number)
                {
                    case 0:
                        f = false;
                        Console.WriteLine("Завершение работы приложения ...");
                        break;

                    case 1:
                        Console.Clear();
                        Task1.Task();
                        break;

                    case 2:
                        Console.Clear();
                        Task2.Task();
                        break;
                    case 3:
                        Console.Clear();
                        Task3.Task();
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный номер задачи.\nПовторите ввод.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }



                //int[] arr = {5, 6, 4, 1, 7, 9, 2, 3};

                //MyArray myArray = new MyArray(arr);
                //myArray[2] = 30;                    // это возможно благодаря созданому индексному свойству
                //myArray.PrintArray();

                //MyArray myArray2 = new MyArray(15);
                //myArray2.PrintArray();



                //MyArray myArray3 = new MyArray(AppDomain.CurrentDomain.BaseDirectory + "MyArray.txt");
                //myArray3.PrintArray();

                //MyArray myArray4 = new MyArray(15, 3, 6);
                //myArray4.PrintArray();

                //myArray4.Inverse();
                //myArray4.PrintArray();

                //int[] newArray = myArray4.InverseNewArr();
                //MyArray myArray5 = new MyArray(newArray);
                //myArray5.PrintArray();

                //myArray.Multi(2);
                //myArray.PrintArray();


                //int sumArray = myArray4.Sum();
                //Console.WriteLine(sumArray);

                //int maxN = myArray2.Max;
                //Console.WriteLine(maxN);



            }

        }
    }

   


}
