using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    delegate double DoOperation(double x, double y);  //Сигнарура данного делегата принимает на вход две переменных типа double и возвращает одну переменную типа double


    internal class Sample03
    {
        public static double Plus(double a, double b)  //Данный метод принимает на вход две переменных типа double и возвращает одну переменную типа double
        {
            Console.Write($"{a} + {b}");
            return a + b;
        }

        public static double Minus(double a, double b)      //Данный метод принимает на вход две переменных типа double и возвращает одну переменную типа double
        {
            Console.Write($"{a} - {b}");
            return a - b;
        }

        public static void Process(DoOperation operation, double param1, double param2) //Метод в рамках которого делегат передается как параметр
        {
            Console.WriteLine($" = {operation(param1, param2)}");

        }



        static void Main(string[] args)
        {
            DoOperation doOperation1 = Plus; //Сигнатуры делегата и метода совпадают

            Process(doOperation1, 5, 12); //Вызываем наш метод в качестве параметров передаем делегат и значение двух переменных

            Process(Minus, 5, 12);  //Мы также в качестве переметра передать сразу метод

            DoOperation doOperation2 = delegate (double a, double b)   //Анонимный метод. объявляется словом delegate входные параметры указываются в скобках, а возвращаемые (при наличии) непосредственно в теле.
            {
                Console.Write($"{a} * {b}");
                return a * b;
            };

            Process(doOperation2, 5, 12);

            //Анонимный метод можно сразу передать как параметр делегата

            Process(delegate (double a, double b)
            {
                Console.Write($"{a} / {b}");
                return a / b;
            }, 5, 12);




            Console.ReadKey();

        }


    }
}
