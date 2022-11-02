using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Растояние между двумя точками";
            Console.WriteLine("Привет, мы можем расчитать растоятие между двумя заданными точками");
            
            Console.WriteLine("Введите координаты первой точки");
            Console.Write("по оси 'Х'");
            int X_1 = int.Parse(Console.ReadLine());
            Console.Write("по оси 'Y'");
            int Y_1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты второй точки");
            Console.Write("по оси 'Х'");
            int X_2 = int.Parse(Console.ReadLine());
            Console.Write("по оси 'Y'");
            int Y_2 = int.Parse(Console.ReadLine());

            var result = Math.Sqrt(Math.Pow(X_2 - X_1, 2) + Math.Pow(Y_2 - Y_1, 2));

            Console.WriteLine($"Растояние между точками равно {result.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadLine();

        }
    }
}
