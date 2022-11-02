using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Sample04
    {
        static bool IsEvenNumber(int i)  //Метод который проверит является ли число четным и вернет истину
        {
            return i % 2 == 0;
        }
        
        
        static void Main(string[] args)
        {
            List<int> list = new List<int>();   //создадим первую коллекцию 
            list.AddRange(new int[] { 1, 2, 3, -3, 565, 34, 22, 78, 2, 43});    //передадим в коллекцию диапазон значений
            List<int> res1 = new List<int>();   //создадим вторую коллекцию

            foreach(int e in list)  //прогоним первую колекцию через foreach
            {
                if (IsEvenNumber(e))    //Прогоним значения первой коллекции через функцию
                    res1.Add(e);    //если вернулась истина добавим значение во вторую коллекцию
            }

            foreach(int e in res1)  //прогоним вторую колекцию через foreach
            {
                Console.Write($"{e}\t");    //выведем значение второй коллекции на экран
            }


            Console.WriteLine();

            //В коллекции List существует метод FindAll который на вход принимает тип Predicate (обобщенную) и на выход отдает коллекцию (обобщенную)
            //Predicate это базовый делегат который на вход берет любую переменную а на выход он выдает булевое значение
            //Наш метод IsEvenNumber совпадает сигнатурой с делегатом Predicate

            //Если мы на в методе FindAll на коллекции list передадим нам метод IsEvenNumber то на выходе мы получим некую коллекцию. Чем мы и воспользуемся.
            
            List<int> res2 = list.FindAll(IsEvenNumber);        //данная запись позволила сократить запись прогонки первой коллекции через foreach заменив его использование базового делегата
            foreach (int e in res1)  //прогоним вторую колекцию через foreach
            {
                Console.Write($"{e}\t");    //выведем значение второй коллекции на экран
            }

            Console.WriteLine();

            //Заменим наш метод IsEvenNumber анонимным методом
            List<int> res3 = list.FindAll(delegate (int i) {return i % 2 == 0; });

            foreach (int e in res1)  //прогоним вторую колекцию через foreach
            {
                Console.Write($"{e}\t");    //выведем значение второй коллекции на экран
            }
            Console.WriteLine();

            //Сократим наш анонимным методом до лямбда выражения
            List<int> res4 = list.FindAll(i => i % 2 == 0);

            foreach (int e in res1)  //прогоним вторую колекцию через foreach
            {
                Console.Write($"{e}\t");    //выведем значение второй коллекции на экран
            }



            Console.ReadKey();

        }



    }
}
