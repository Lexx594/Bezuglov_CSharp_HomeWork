using Lexx.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace HomeWork6
{
    public class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Создаем конструктор
        public Student(string firstName, string lastName, string university,
        string faculty, string department, int age, int course, int group, string city)
        {
            this.firstName = firstName; 
            this.lastName = lastName;             
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.group = group;
            this.city = city;
        }
    }

   
    internal class Task3
    {

        public static int AgeStudentCompare(Student st1, Student st2) 
        {
            return String.Compare(st1.Age.ToString(), st2.Age.ToString()); //Сравниваем две строки
        }
        public static int СourseStudentCompare(Student st1, Student st2)
        {
            return String.Compare(st1.course.ToString(), st2.course.ToString()); //Сравниваем две строки
        }



        public static void Task()
        {

            bool f = true;

            while (f)
            {
                Console.Title = "Использование коллекций";
                OutputHelpers.PrintInfo(6, Menu.number, "Безуглов Алексей");

                OutputHelpers.Heading("Использование коллекций");

                Console.WriteLine("Меню задания № 3");
                Console.WriteLine("=======================================================================");
                Console.WriteLine("1 -> Количество студентов учащихся на 5 и 6 курсах");
                Console.WriteLine("2 -> Количество студентов в возрасте от 18 до 20 лет на каком курсе учатся");
                Console.WriteLine("3 -> Отсортировать список по возрасту студента");
                Console.WriteLine("4 -> Отсортировать список по курсу и возрасту студента");
                Console.WriteLine("0 -> Возвращение в меню задач");
                Console.WriteLine("=======================================================================\n");

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
        }

        static void Task11()
        {
            OutputHelpers.Heading("Количество студентов учащихся на 5 и 6 курсах");
            int course5 = 0;
            int course6 = 0;
            List<Student> student = new List<Student>();
            StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "students_6.csv");            
            while (!streamReader.EndOfStream)        //будем считывать данные пока не дойдем до конца файла
            {
                 string[] studentString = streamReader.ReadLine().Split(';');
                 // под каждую итерацию цикла будем создавать новый объект, заполняем кождое его свойство и передаем в коллекцию student
                 student.Add(new Student(studentString[0], studentString[1], studentString[2], studentString[3], studentString[4], int.Parse(studentString[5]), int.Parse(studentString[6]), int.Parse(studentString[7]), studentString[8]));
                 if (int.Parse(studentString[6]) == 5) course5++;
                 if (int.Parse(studentString[6]) == 6) course6++;
            }
            streamReader.Close();
            Console.WriteLine($"На пятом курсе учатся {course5} студента(ов)");
            Console.WriteLine($"На шестом курсе учатся {course6} студента(ов)");
            Console.WriteLine("\nНажмите Enter для возврата в меню задания");
            Console.ReadLine();
            Console.Clear();
        }

        static void Task12()
        {
            OutputHelpers.Heading("Количество студентов в возрасте от 18 до 20 лет на каком курсе учатся");
            int studentAge = 0;
            List<Student> student = new List<Student>();
            StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "students_6.csv");
            Dictionary<int, int> courseDict = new Dictionary<int, int>();

            while (!streamReader.EndOfStream)
            {
                string[] studentString = streamReader.ReadLine().Split(';');
                student.Add(new Student(studentString[0], studentString[1], studentString[2], studentString[3], studentString[4], int.Parse(studentString[5]), int.Parse(studentString[6]), int.Parse(studentString[7]), studentString[8]));
                if (int.Parse(studentString[5]) <= 20 && int.Parse(studentString[5]) >= 18)
                {
                    studentAge++;
                    if (courseDict.ContainsKey(int.Parse(studentString[6])))
                        courseDict[int.Parse(studentString[6])] += 1;
                    else
                        courseDict.Add(int.Parse(studentString[6]), 1);
                }
            }
            streamReader.Close();
            Console.WriteLine($"В возрасте от 18 до 20 лет учатся {studentAge} студент(а)");
            foreach (KeyValuePair<int, int> element in courseDict)
            {
                Console.WriteLine($"на {element.Key} курсе {element.Value} студент(а)");
            }            
            Console.WriteLine("\nНажмите Enter для возврата в меню задания");
            Console.ReadLine();
            Console.Clear();
        }

        static void Task13()
        {
            OutputHelpers.Heading("Отсортировать список по возрасту студента");


            List<Student> student = new List<Student>();
            StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "students_6.csv");
            while (!streamReader.EndOfStream)        
            {
                string[] studentString = streamReader.ReadLine().Split(';');
                student.Add(new Student(studentString[0], studentString[1], studentString[2], studentString[3], studentString[4], int.Parse(studentString[5]), int.Parse(studentString[6]), int.Parse(studentString[7]), studentString[8]));
            }
            streamReader.Close();
            student.Sort(new Comparison<Student>(AgeStudentCompare));
            foreach (Student v in student)
            {
                Console.WriteLine($"Студент {v.firstName} {v.lastName}, {v.Age} лет(года) учится на {v.course} курсе");
            }
            Console.WriteLine("\nНажмите Enter для возврата в меню задания");
            Console.ReadLine();
            Console.Clear();
        }
        static void Task14()
        {
            OutputHelpers.Heading("Отсортировать список по курсу и возрасту студента");


            List<Student> student = new List<Student>();
            StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "students_6.csv");
            while (!streamReader.EndOfStream)
            {
                string[] studentString = streamReader.ReadLine().Split(';');
                student.Add(new Student(studentString[0], studentString[1], studentString[2], studentString[3], studentString[4], int.Parse(studentString[5]), int.Parse(studentString[6]), int.Parse(studentString[7]), studentString[8]));
            }
            streamReader.Close();
            student.Sort(new Comparison<Student>(AgeStudentCompare));
            student.Sort(new Comparison<Student>(СourseStudentCompare));
            foreach (Student v in student)
            {
                Console.WriteLine($"Студент {v.firstName} {v.lastName}, {v.Age} лет(года) учится на {v.course} курсе");
            }
            Console.WriteLine("\nНажмите Enter для возврата в меню задания");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
