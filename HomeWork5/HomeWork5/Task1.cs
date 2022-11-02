using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class Task1
    {
        public static void Task()
        {
            Console.Title = "Проверка корректности ввода логина";
            Lexx.Utils.OutputHelpers.PrintInfo(5, Menu.number, "Безуглов Алексей");

            Lexx.Utils.OutputHelpers.Heading("Проверка корректности ввода логина");

            Console.WriteLine("Регистрация аккаунта");
            Account acc1;
            acc1.login = string.Empty;
            Lexx.Utils.OutputHelpers.CheckLogin(ref acc1.login);
            Console.Write("Введите пароль: ");
            acc1.password = Console.ReadLine();
            acc1.WriteAccount();

            Console.WriteLine("\nВы успешно зарегистрировали аккаунт со следующими параметрами:");
            Console.WriteLine(acc1);

            Console.WriteLine("\nНажмите пробел чтобы зарегистрировать новый аккаунт или иную клавишу чтобы выйти в меню");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Task();
            }
            Console.Clear();
        }
    }

    struct Account
    {
        public string login;
        public string password;

        public override string ToString()
        {
            return $"Логин: {login}\nПароль: {password}";
        }

        public void WriteAccount()
        {
            StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "LogPas.txt", true);
            writer.WriteLine(login);
            writer.WriteLine(password);
            writer.Close();
        }


    }


}

