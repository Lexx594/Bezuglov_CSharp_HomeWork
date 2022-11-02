using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Анкета";
            Console.WriteLine("Привет, это небольшая анкету, которую тебе предстоит пройти");
            Console.WriteLine("Она состоит всего из нескольких вопросов");

            Console.Write("Как вас зовут? ");
            string name = Console.ReadLine();

            Console.Write("Какая у вас фамилия? ");
            string surname = Console.ReadLine();

            Console.Write("Сколько вам лет? ");
            string age = Console.ReadLine();

            Console.Write("Какой у вас рост (в сантиметрах)? ");
            string height = Console.ReadLine();

            Console.Write("Какой у вас вес (в килограммах)? ");
            string weight = Console.ReadLine();

            Console.WriteLine("Здравствуйте " + surname + " " + name + " вам " + age + " лет (год), ваш рост " + height + " сантиметров, а вес " + weight + " килограмм");
            Console.WriteLine("Здравствуйте {0} {1} вам {2} лет (год), ваш рост {3} сантиметров, а вес {4} килограмм", surname, name, age, height, weight);
            Console.WriteLine($"Здравствуйте {surname} {name} вам {age} лет (год), ваш рост {height} сантиметров, а вес {weight} килограмм");

            double double_height = double.Parse(height);
            double double_weight = double.Parse(weight);


            double BodyMassIndex = double_weight / ((double_height / 100)*(double_height / 100));
            Console.WriteLine($"Ваш индекс массы тела равен {Math.Round(BodyMassIndex, 1)}");

            Console.ReadLine();


        }
    }
}
