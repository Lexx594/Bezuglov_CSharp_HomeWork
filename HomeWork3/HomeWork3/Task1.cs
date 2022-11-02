using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Task1
    {

        public static void Task()
        {
            bool f = true;

            while (f)
            {
                //Console.Clear();
                Lexx.Utils.OutputHelpers.PrintInfo(3, Menu.number, "Безуглов Алексей");

                Lexx.Utils.OutputHelpers.Heading("Работа с структурой Complex");



                Console.WriteLine("Меню задания № 1");
                Console.WriteLine("===================================================");
                Console.WriteLine("1 -> Сложение комплексных чисел структурой Complex");
                Console.WriteLine("2 -> Вычитания комплексных чисел структурой Complex");
                Console.WriteLine("3 -> Умножение комплексных чисел структурой Complex");
                Console.WriteLine("4 -> Деление комплексных чисел структурой Complex");
                Console.WriteLine("0 -> Возвращение в меню задач");
                Console.WriteLine("===================================================\n");

                Console.Write("Введите номер задания: ");
                int taskNumber;
                if (int.TryParse(Console.ReadLine(), out taskNumber))
                { }
                else
                {
                    taskNumber = 10;
                }

                switch (taskNumber)
                {
                    case 0:
                        f = false;
                        Console.Clear();
                        break;

                    case 1:
                        Console.Clear();
                        structComplexPlus();
                        break;

                    case 2:
                        Console.Clear();
                        structComplexMinus();
                        break;

                    case 3:
                        Console.Clear();
                        structComplexMultiplication();
                        break;
                    
                    case 4:
                        Console.Clear();
                        structComplexDivision();
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный номер задания.\nПовторите ввод.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

            
            }


          
        }
        public static void structComplexPlus()
        {
            Lexx.Utils.OutputHelpers.Heading("Сложение комплексных чисел структурой Complex");

            ComplexStruct complex1;
            Console.Write("Введите действительную часть первого комплексно числа: ");
           
            while(!double.TryParse(Console.ReadLine(), out complex1.re))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод. Необходимо вводить число.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            Console.Write("Введите мнимую часть первого комплексно числа: ");

            while(!double.TryParse(Console.ReadLine(), out complex1.im))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод. Необходимо вводить число.");
                Console.ForegroundColor = ConsoleColor.White;
            }
                        

            ComplexStruct complex2;
            Console.Write("Введите действительную часть второго комплексно числа: ");
            while (!double.TryParse(Console.ReadLine(), out complex2.re))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод. Необходимо вводить число.");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Write("Введите мнимую часть второго комплексно числа: ");
            while (!double.TryParse(Console.ReadLine(), out complex2.im))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод. Необходимо вводить число.");
                Console.ForegroundColor = ConsoleColor.White;
            }


            ComplexStruct complex3 = complex1.Plus(complex2);

            Console.WriteLine($"Результат сложения заданных комплексных чисел {complex1} и {complex2} равен {complex3}");


            Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                structComplexPlus();
            }
            Console.Clear();



        }

        public static void structComplexMinus()
        {
            
            Lexx.Utils.OutputHelpers.Heading("Вычитание комплексных чисел структурой Complex");

            ComplexStruct complex1;
            Console.Write("Введите действительную часть первого комплексно числа: ");
            if (double.TryParse(Console.ReadLine(), out complex1.re)) ;
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод.\nНеобходимо вводить число.");
                Console.ForegroundColor = ConsoleColor.White;
                structComplexMinus();
            }


            Console.Write("Введите мнимую часть первого комплексно числа: ");
            if (double.TryParse(Console.ReadLine(), out complex1.im)) ;
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод.\nНеобходимо вводить число.");
                Console.ForegroundColor = ConsoleColor.White;
                structComplexMinus();
            }


            ComplexStruct complex2;
            Console.Write("Введите действительную часть второго комплексно числа: ");
            if (double.TryParse(Console.ReadLine(), out complex2.re)) ;
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод.\nНеобходимо вводить число.");
                Console.ForegroundColor = ConsoleColor.White;
                structComplexMinus();
            }

            Console.Write("Введите мнимую часть второго комплексно числа: ");
            if (double.TryParse(Console.ReadLine(), out complex2.im)) ;
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод.\nНеобходимо вводить число.");
                Console.ForegroundColor = ConsoleColor.White;
                structComplexMinus();
            }

            ComplexStruct complex3 = complex1.Minus(complex2);

            Console.WriteLine($"Результат вычитания комплексного чисела {complex2} из комплексного числа {complex1} равен {complex3}");

            Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                structComplexMinus();
            }
            Console.Clear();

        }

        public static void structComplexMultiplication()
        {
            Lexx.Utils.OutputHelpers.Heading("Умножение комплексных чисел структурой Complex");

            ComplexStruct complex1;
            Console.Write("Введите действительную часть первого комплексно числа: ");
            if (double.TryParse(Console.ReadLine(), out complex1.re)) ;
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод.\nНеобходимо вводить число.");
                Console.ForegroundColor = ConsoleColor.White;
                structComplexMultiplication();
            }


            Console.Write("Введите мнимую часть первого комплексно числа: ");
            if (double.TryParse(Console.ReadLine(), out complex1.im)) ;
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод.\nНеобходимо вводить число.");
                Console.ForegroundColor = ConsoleColor.White;
                structComplexMultiplication();
            }


            ComplexStruct complex2;
            Console.Write("Введите действительную часть второго комплексно числа: ");
            if (double.TryParse(Console.ReadLine(), out complex2.re)) ;
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод.\nНеобходимо вводить число.");
                Console.ForegroundColor = ConsoleColor.White;
                structComplexMultiplication();
            }

            Console.Write("Введите мнимую часть второго комплексно числа: ");
            if (double.TryParse(Console.ReadLine(), out complex2.im)) ;
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод.\nНеобходимо вводить число.");
                Console.ForegroundColor = ConsoleColor.White;
                structComplexMultiplication();
            }


            ComplexStruct complex3 = complex1.Multiplication(complex2);

            Console.WriteLine($"Результат умножения заданных комплексных чисел {complex1} и {complex2} равен {complex3}");


            Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                structComplexMultiplication();
            }

            Console.Clear();



        }

        public static void structComplexDivision()
        {
            
            Lexx.Utils.OutputHelpers.Heading("Деление комплексных чисел структурой Complex");

            ComplexStruct complex1;
            Console.Write("Введите действительную часть делимого комплексно числа: ");
            if (double.TryParse(Console.ReadLine(), out complex1.re)) ;
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод.\nНеобходимо вводить число.");
                Console.ForegroundColor = ConsoleColor.White;
                structComplexDivision();
            }


            Console.Write("Введите мнимую часть делимого комплексно числа: ");
            if (double.TryParse(Console.ReadLine(), out complex1.im)) ;
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод.\nНеобходимо вводить число.");
                Console.ForegroundColor = ConsoleColor.White;
                structComplexDivision();
            }


            ComplexStruct complex2;
            Console.Write("Введите действительную часть делителя комплексно числа: ");
            if (double.TryParse(Console.ReadLine(), out complex2.re)) ;
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод.\nНеобходимо вводить число.");
                Console.ForegroundColor = ConsoleColor.White;
                structComplexDivision();
            }
            if (complex2.re == 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод.\nНа ноль делить нельзя.");
                Console.ForegroundColor = ConsoleColor.White;
                structComplexDivision();

            }

            Console.Write("Введите мнимую часть делителя комплексно числа: ");
            if (double.TryParse(Console.ReadLine(), out complex2.im)) ;
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод.\nНеобходимо вводить число.");
                Console.ForegroundColor = ConsoleColor.White;
                structComplexDivision();
            }
            if (complex2.im == 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод.\nНа ноль делить нельзя.");
                Console.ForegroundColor = ConsoleColor.White;
                structComplexDivision();

            }

            ComplexStruct complex3 = complex1.Division(complex2);

            Console.WriteLine($"Результат деления комплексного чисела {complex1} на комплексное число {complex2} равен {complex3}");

            Console.WriteLine("\nНажмите пробел для повторения текущего задания или иную клавишу чтобы выйти в меню задания");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                structComplexDivision();
            }

            Console.Clear();

        }


    }


    struct ComplexStruct
    {

        public double re;      //действительная часть комплексного числа
        public double im;      //Мнимая часть комплексного числа

        public override string ToString() //Преопределяем метод работы ToString (т.е. в каком виде нам покажут в консоле переменную Complex)
        {
            return $"{re} + {im}i";
        }
    
        public ComplexStruct Plus(ComplexStruct x)
        {
            ComplexStruct complexRes;
            complexRes.re = re + x.re;
            complexRes.im = im + x.im;
            return complexRes;
        }


        public ComplexStruct Minus(ComplexStruct x)
        {
            ComplexStruct complexRes;
            complexRes.re = re - x.re;
            complexRes.im = im - x.im;
            return complexRes;
        }

        public ComplexStruct Multiplication(ComplexStruct x)
        {
            ComplexStruct complexRes;
            complexRes.re = re * x.re;
            complexRes.im = im * x.im;
            return complexRes;
        }


        public ComplexStruct Division(ComplexStruct x)
        {
            ComplexStruct complexRes;
            complexRes.re = re / x.re;
            complexRes.im = im / x.im;
            return complexRes;
        }




    }
     


}
