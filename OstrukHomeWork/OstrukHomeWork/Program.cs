using System;
using Library;

namespace OstrukHomeWork
{
    class Program
    {
        public static int Index = 0; // camalCase index Дальше по коду соответсвенно , почему mess например правильно? приучай себя к одному стилю
        public static string mess = "";

        public static Group[] groups = new Group[3] { new Group("First", "Assistant Professor"),
            new Group("Second", "Lecturer"),
            new Group("Third", "Assistant")};

        static void Main(string[] args)
        { // кто то линивая ... не захотел тут цикл написать 
            AddStudent(new Student("Serhii1", "Ostruk1"));
            AddStudent(new Student("Serhii2", "Ostruk2"));
            AddStudent(new Student("Serhii3", "Ostruk3"));
            AddStudent(new Student("Serhii4", "Ostruk4"));
            AddStudent(new Student("Serhii5", "Ostruk5"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));
            AddStudent(new Student("Serhii6", "Ostruk6"));

            foreach(var group in groups)
            {
                group.PrintGroup();
            }

            Console.ReadKey();
        }

        public static void AddStudent(Student student)
        {
            if (mess != "")
            {
                Console.WriteLine(mess);
                Index++;
            }
            if (Index < 3) // магические числа => выноси в переменую с самодокументируемым названием что это
            {
                mess = groups[Index].Add(student);
            }
            if(Index == 3)
            {
                Console.WriteLine("All groups is overload!");
            }
        }
    }
}
