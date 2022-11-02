using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexx.Utils
{
    public class MyArray
    {

        private int[] array;


        // Индексное свойство (доступ к этому свойству осуществляется по индексу)
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }

        }


        public MyArray(int[] array)             //Конструктор (передать существующий массив)
        {
            this.array = array;

        }

        public MyArray(int size)             //Перегрузим конструктор (создать массив заданного размера заполненный случайными числами)
        {
            Random random = new Random();
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-99, 100);
            }

        }

       








        public MyArray(string fileName)             //Перегрузим конструктор (создать массив считав его из файла по его имени)
        {
            array = LoadArrayFromFile(fileName);

        }

        public MyArray(int size, int firstNumber, int step)     // Перегрузим конструктор (создать массив определенного размера и заполняющий массив числами от начального значения с заданным шагом)
        {

            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = firstNumber;
                firstNumber += step;
            }

        }


        //public MyArray(int n, int min, int max)
        //{
        //    array = new int[n];
        //    Random rnd = new Random();

        //    for (int i = 0; i < n; i++)
        //        array[i] = rnd.Next(min, max);
        //}

        public int Max      //Свойство определяющее максимальное число массива
        {
            get
            {
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                    if (array[i] > max) max = array[i];
                return max;
            }
        }

        public int Min      //Свойство определяющее минимальное число массива
        {
            get
            {
                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                    if (array[i] < min) min = array[i];
                return min;
            }
        }

        public int MaxCount      //Свойство определяющее количество максимальных чисел в массиве
        {
            
            get
            {
                int count = 0;
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                    if (array[i] > max) max = array[i];

                for (int i = 0; i < array.Length; i++)
                    if (array[i] == max) count++;

                return count;
            }
            
        
        }




        public void PrintArray()        // метод для печати массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();
        }

        public int Sum()            // метод возвращает сумму элементов массива
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public int[] Inverse()      // метод изменяет знаки у всех элементов текущего массива
        {            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= -1;
            }
            return array;
        }

        public int[] InverseNewArr()      // метод создает новый массив с измененными знаками у всех элементов массива
        {
            int [] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i] * -1;
            }
            return newArray;
        }

        public int[] Multi(int number)      // метод умножающий каждый элемент массива на определённое число
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= number;
            }
            return array;
        }





        private int[] LoadArrayFromFile(string fileName) // Это служебный метод, поэтому помечаем его модификатором private
        {
            if (File.Exists(fileName))     //Здесь потребовалось выбрать к чему относится класс File
            {
                StreamReader streamReader = new StreamReader(fileName);
                int[] buf = new int[1000];
                int count = 0;


                while (!streamReader.EndOfStream)
                {
                    buf[count] = int.Parse(streamReader.ReadLine());
                    count++;
                }
                int[] arr = new int[count];     //создаем новый массив с разменостью длины предыдущего массива
                Array.Copy(buf, arr, count); // копируем массив в массив
                streamReader.Close();   //Закрываем поток установленный с файлом
                return arr;
            }

            else
                throw new FileNotFoundException();

        }


    }
}
