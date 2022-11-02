using Lexx.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Task2
    {


        public static void Task()
        {




            string message = "Если тебе тяжело, значит ты поднимаешься в гору. Если тебе легко, значит ты летишь в пропасть.";


            bool f = true;

            while (f)
            {
                Console.Title = "Методы класса Message";
                OutputHelpers.PrintInfo(5, Menu.number, "Безуглов Алексей");

                OutputHelpers.Heading("Методы класса Message");

                Console.WriteLine("Меню задания № 1");
                Console.WriteLine("==============================================================================");
                Console.WriteLine("1 -> Выводим слова содержащие заданное количество букв");
                Console.WriteLine("2 -> Удалим из сообщения все слова, заканчивающиеся на заданную букву");
                Console.WriteLine("3 -> Находим самое длинное слово сообщения");
                Console.WriteLine("4 -> Сформируем строку с помощью StringBuilder из самых длинных слов сообщения");
                Console.WriteLine("0 -> Возвращение в меню задач");
                Console.WriteLine("==============================================================================\n");

                Console.Write("Введите номер задания: ");
                int taskNumber;
                if (int.TryParse(Console.ReadLine(), out taskNumber)) { }
                else { taskNumber = 10; }

                switch (taskNumber)
                {
                    case 0:
                        f = false;
                        Console.Clear();
                        break;

                    case 1:
                        Console.Clear();
                        Task11();
                        break;

                    case 2:
                        Console.Clear();
                        Task12();
                        break;

                    case 3:
                        Console.Clear();
                        Task13();
                        break;

                    case 4:
                        Console.Clear();
                        Task14();
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный номер задания.\nПовторите ввод.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

            }

            void Task11()
            {
                

                OutputHelpers.Heading("Выводим слова содержащие заданное количество букв");
                Console.WriteLine("Вам дано выражение");
                Console.WriteLine(message);
                Console.WriteLine();
                int number = 0;
                OutputHelpers.CheckNumber("Задайте предельный размер выводимого слова: ", ref number);
                Message.PrintWordsLenth(message, number);

                Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    Task11();
                }
                Console.Clear();
            }

            void Task12()
            {


                OutputHelpers.Heading("Удалим из сообщения все слова, заканчивающиеся на заданную букву");
                Console.WriteLine("Вам дано выражение");
                Console.WriteLine(message);
                Console.WriteLine();
                Console.Write("Введите букву: ");                                
                char ch = Convert.ToChar(Console.ReadLine());
                Message.DelWords(message, ch);
                
                Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    Task12();
                }
                Console.Clear();
            }


            void Task13()
            {


                OutputHelpers.Heading("Находим самое длинное слово сообщения");
                Console.WriteLine("Вам дано выражение");
                Console.WriteLine(message);
                Console.WriteLine();
                Message.MaxWords(message);
                Console.WriteLine();
                Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    Task13();
                }
                Console.Clear();
            }


            void Task14()
            {


                OutputHelpers.Heading("Сформируем строку с помощью StringBuilder из самых длинных слов сообщения");
                Console.WriteLine("Вам дано выражение");
                Console.WriteLine(message);
                Console.WriteLine();
                Message.MaxWordsNewString(message);
                Console.WriteLine();
                Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    Task14();
                }
                Console.Clear();
            }



        }   
    }

    public static class Message
    {
        private static string[] separators = { ".", ",", "!", "?", ";", ":", " ", "-" }; // Создаем массив с разделитеми, которые могут быть использованы в строке
    
        public static void PrintWords(string message)       // Метод позволяющий написать слова имеющие более 3 букв, а также начинаются и заканчиваются на одинаковую букву
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 3 && words[i][0].Equals(words[i][words[i].Length - 1]))
                Console.WriteLine(words[i]);
            }
        }
        public static void PrintWordsLenth(string message, int number)       // Метод позволяющий вывести только те слова сообщения, которые содержат не более n букв
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= number)
                    Console.WriteLine(words[i]);
            }
        }

        public static void DelWords(string message, char symbol)       // Метод позволяющий удалить из сообщения все слова, которые заканчиваются на заданный символ.
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!(words[i][words[i].Length - 1] == symbol)) Console.Write(words[i] + " ");
            }
        }

        public static void MaxWords(string message)       // Метод позволяющий найти самое длинное слово сообщения.
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int max = words[0].Length;
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > max) max = words[i].Length;
            }
            int count = 0;
            Console.Write("Самое длинное слово сообщения: ");
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length == max)
                {
                    count++;
                    if (count >= 2)
                    {
                        Console.Write(", ");
                        Console.Write(words[i]);
                    }
                    else Console.Write(words[i]);
                }                              
            }
        }

        public static void MaxWordsNewString(string message)       // Метод позволяющий cформировать строку с помощью StringBuilder из самых длинных слов сообщения..
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int max = words[0].Length;
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > max) max = words[i].Length;
            }
            int count = 0;
            
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length == max)
                {
                    stringBuilder.Append(words[i] + " ");
                }
            }
            Console.WriteLine(stringBuilder);
        }





    }


}
