using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Program
    {
        static void Main1()
        {

            char[] arr = new char[] { '1', 's', '$', 'M', '+' };
            for (int i = 0; i < arr.Length; i++)
            {
                UnicodeCategory unicodeCategory = char.GetUnicodeCategory(arr[i]);
                switch (unicodeCategory)
                {
                    case UnicodeCategory.UppercaseLetter:
                        Console.WriteLine($"{arr[i]} символ в верхнем регистре");
                        break;
                    case UnicodeCategory.LowercaseLetter:
                        Console.WriteLine($"{arr[i]} символ в нижнем регистре");
                        break;
                    case UnicodeCategory.DecimalDigitNumber:
                        Console.WriteLine($"{arr[i]} число");
                        break;
                    case UnicodeCategory.MathSymbol:
                        Console.WriteLine($"{arr[i]} математический символ");
                        break;
                    default:
                        Console.WriteLine($"{arr[i]} другое...");
                        break;
                }
            }

            Console.ReadLine();

        }
    }
}
