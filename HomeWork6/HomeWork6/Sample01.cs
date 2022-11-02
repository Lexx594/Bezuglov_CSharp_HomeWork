using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Sample01
    {
        
        class User
        {
            public string Name { get; set; }        //такая запись обертки полей желательна всегда кокда не требуется специальной обертки
            public string Surname { get; set; }
            public string Middlename { get; set; }
            public DateTime Birthday { get; set; }
        }
            
        
        
        
        static void Main(string[] args)
        {

            //Пример необобщенной коллекции

            ArrayList users = new ArrayList(); //Создаем коллекцию
            StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "UserList.txt");
            while (!streamReader.EndOfStream)        //будем считывать данные пока не дойдем до конца файла
            {
                string[] words = streamReader.ReadLine().Split(' ');       // метод Split(' ') разделяет слова по пробелу

                // под каждую итерациюцикла будем создавать новый объект
                User user = new User();
                // И заполняем кождое его свойство                
                user.Surname = words[0];
                user.Name = words[1];
                user.Middlename = words[2];
                user.Birthday = DateTime.Parse(words[3]); // Дату необходимо преобразовать
                // далее объект user добавлям в коллекцию users
                users.Add(user);
            }    

            streamReader.Close();

            foreach (object user in users)
            {                  
                if (user is User)   // даное выражение проверяет является ли этот объект типа User
                    //преобразовывает переменную типа object к переменной типа User и вызываем соответсвующие методы Surname, Name, Birthday
                    Console.WriteLine($"{((User)user).Surname} {((User)user).Name} {((User)user).Middlename} {((User)user).Birthday.ToShortDateString()}");       // к Birthday применяем ToShortDateString() для правильного вывода формата
            }

            Console.WriteLine();

            //Пример обобщенной коллекции

            List<User> users2 = new List<User>();
            StreamReader streamReader2 = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "UserList.txt");
            while (!streamReader2.EndOfStream)        //будем считывать данные пока не дойдем до конца файла
            {
                string[] words = streamReader2.ReadLine().Split(' ');       // метод Split(' ') разделяет слова по пробелу

                // под каждую итерацию цикла будем создавать новый объект
                User user = new User();
                // И заполняем кождое его свойство                
                user.Surname = words[0];
                user.Name = words[1];
                user.Middlename = words[2];
                user.Birthday = DateTime.Parse(words[3]); // Дату необходимо преобразовать
                // далее объект user добавлям в коллекцию users
                users2.Add(user);
            }
            foreach (User user in users2)
            {
                //if (user is User)   // данная проверка не требуется
                    //преобразовывать теперь не нужно. Вызываем соответсвующие методы Surname, Name, Birthday
                    Console.WriteLine($"{user.Surname} {user.Name} {user.Middlename} {user.Birthday.ToShortDateString()}");       // к Birthday применяем ToShortDateString() для правильного вывода формата
            }

            Console.ReadLine(); 




        }
    }
}
