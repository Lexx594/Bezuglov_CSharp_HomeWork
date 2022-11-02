using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Свойства структуры DateTime";
            Lexx.Utils.OutputHelpers.PrintInfo(8, 1, "Безуглов Алексей");
            
            Lexx.Utils.OutputHelpers.Heading("Выводим все свойства структуры DateTime");
            
            Type type = typeof(DateTime);
            foreach (PropertyInfo propertyInfo in type.GetProperties())         //Возвращает все открытые свойства текущего объекта Type
                Console.WriteLine(propertyInfo.Name);
            
            Lexx.Utils.OutputHelpers.Heading("Бонусом выведем все методы структуры DateTime");

            foreach (MethodInfo methodInfo in type.GetMethods())            //Возвращает все открытые методы текущего объекта Type
                Console.WriteLine(methodInfo.Name);

            Console.ReadKey();

        }
    }
}
