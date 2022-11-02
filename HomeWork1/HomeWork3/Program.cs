using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Обмен значениями двух переменных";
            Console.WriteLine("Привет, здесь мы проведен обмен значениями двух переменных с использованием третьей переменной");
            
            Console.WriteLine("Введите числовое значение первой переменной");
            int Number_1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите числовое значение второй переменной");
            int Number_2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Проговариваем про себя: 'Абра-кадабра', 'Сим-салабим'... и теперь...");


            int Number_3 = Number_1;
            Number_1 = Number_2;
            Number_2 = Number_3;
            Console.WriteLine($"Значение первой переменной равно {Number_1}, второй - {Number_2}");



            Console.ReadLine();

        }
    }
}
