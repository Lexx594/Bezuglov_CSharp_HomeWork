using Lexx.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Task2
    {
        public delegate double Fun2(double x);

        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double F2(double x)
        {
            return x * x - 50 * x + 20;
        }

        public static double F3(double x)
        {
            return x * x - 50 * x + 30;
        }

        public static void SaveFunc(string fileName, double a, double b, double h, Fun2 FunArr)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create,
            FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(FunArr(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }

        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] doubleArr = new double[fs.Length];
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                doubleArr[i] = (bw.ReadDouble());
            }
            bw.Close();
            fs.Close();
            min = double.MaxValue;
            for (int i = 0; i < doubleArr.Length; i++)
                if (doubleArr[i] < min) min = doubleArr[i];
            return doubleArr;
        }

        //public static double Load(string fileName)
        //{
        //    FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        //    BinaryReader bw = new BinaryReader(fs);
        //    double min = double.MaxValue;
        //    double d;
        //    for (int i = 0; i < fs.Length / sizeof(double); i++)
        //    {
        //        d = bw.ReadDouble();
        //        if (d < min) min = d;
        //    }
        //    bw.Close();
        //    fs.Close();
        //    return min;
        //}

        public static void Task()
        {
            Console.Title = "Программа нахождения минимума функции";
            OutputHelpers.PrintInfo(6, Menu.number, "Безуглов Алексей");

            OutputHelpers.Heading("Программа нахождения минимума функции");
            double min;
            Fun2[] FunArr = {F1, F2, F3};
            int index = 0;
            Console.WriteLine("==========================");
            Console.WriteLine("1 -> Решение с функцией №1");
            Console.WriteLine("2 -> Решение с функцией №2");
            Console.WriteLine("3 -> Решение с функцией №3");
            Console.WriteLine("==========================\n");
            Console.Write("Выберите решение: ");
            while (!(index>0 && index<4))
            {                
                int.TryParse(Console.ReadLine(), out index);
                if (index<1 || index>3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Некорректный ввод. Повторите ввод: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            SaveFunc("data.bin", -100, 100, 0.5, FunArr[index - 1]);
            //Console.WriteLine(Load("data.bin"));
            Load("data.bin", out min);
            Console.WriteLine(min);

            Console.WriteLine("\nНажмите пробел чтобы повторить текущее задание или иную клавишу чтобы выйти в меню");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                Task();
            }
            Console.Clear();
        } 
    }     
}




