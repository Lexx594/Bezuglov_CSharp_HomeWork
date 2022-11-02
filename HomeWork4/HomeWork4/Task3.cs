using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class Task3
    {

        public static void Task()
        {
            Console.Title = "Создание аккаунта";
            Lexx.Utils.OutputHelpers.PrintInfo(4, Menu.number, "Безуглов Алексей");

            Lexx.Utils.OutputHelpers.Heading("Создание аккаунта");

            Console.WriteLine("Регистрация аккаунта");
            Account acc1;
            Console.Write("Введите логин: ");
            acc1.login = Console.ReadLine();
            Console.Write("Введите пароль: ");
            acc1.password = Console.ReadLine();
            acc1.WriteAccount();

            Console.WriteLine("\nВы успешно зарегистрировали аккаунт со следующими параметрами:");
            Console.WriteLine(acc1);

            Console.WriteLine("\nНажмите пробел чтобы зарегистрировать новый аккаунт или иную клавишу чтобы выйти в меню");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
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

        //Как я понял это не работает со структурой
        //public string Login
        //{
        //    get { return login; }
        //    set 
        //    {
        //        if (Login.Length < 3)
        //            throw new Exception("Логин должен состоять не менне чем из 3 символов");
        //        else
        //            login = value; 
        //    }
        //}

        //public string Password
        //{
        //    get { return password; }
        //    set
        //    {
        //        if (Password.Length < 4)
        //            throw new Exception("Пароль должен содержать не менне чем 4 символов");
        //        else
        //            password = value;
        //    }
        //} 

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
