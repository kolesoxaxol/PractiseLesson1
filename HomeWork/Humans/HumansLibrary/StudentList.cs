using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humans.HumansClass;
using Humans.Groups;

namespace Humans.HumansLibrary
{
    public static class StudentList
    {

        static List<Student> _studentList;
        //Some students are temporaly not in the list, because it's easier to test programm with lesser amount of people.
        static StudentList()
        {
            // 0 int group number states for "Not in group" as groups count from 1 to 3.
            _studentList = new List<Student>();

            _studentList.Add(new Student("Vasya1", "Petkin1", 24, 0));
            _studentList.Add(new Student("Vasya2", "Petkin2", 23, 0));
            _studentList.Add(new Student("Vasya3", "Petkin3", 22, 0));
            _studentList.Add(new Student("Vasya4", "Petkin4", 21, 0));
            _studentList.Add(new Student("Vasya5", "Petkin5", 20, 0));

            _studentList.Add(new Student("Dima1", "Lebedev1", 24, 0));
            //_studentList.Add(new Student("Dima2", "Lebedev2", 23, 0));
            //_studentList.Add(new Student("Dima3", "Lebedev3", 22, 0));
            //_studentList.Add(new Student("Dima4", "Lebedev4", 21, 0));
            //_studentList.Add(new Student("Dima5", "Lebedev5", 20, 0));

            //_studentList.Add(new Student("Vanya1", "Smolin1", 24, 0));
            //_studentList.Add(new Student("Vanya2", "Smolin2", 23, 0));
            //_studentList.Add(new Student("Vanya3", "Smolin3", 22, 0));
            //_studentList.Add(new Student("Vanya4", "Smolin4", 21, 0));
            //_studentList.Add(new Student("Vanya5", "Smolin5", 20, 0));

            //_studentList.Add(new Student("Slavik1", "Petrushin1", 24, 0));
            //_studentList.Add(new Student("Slavik2", "Petrushin2", 23, 0));
            //_studentList.Add(new Student("Slavik3", "Petrushin3", 22, 0));
            //_studentList.Add(new Student("Slavik4", "Petrushin4", 21, 0));
            //_studentList.Add(new Student("Slavik5", "Petrushin5", 20, 0));

            //_studentList.Add(new Student("Vasya1", "Smolin1", 24, 0));
            //_studentList.Add(new Student("Vasya2", "Smolin2", 23, 0));
            //_studentList.Add(new Student("Vasya3", "Smolin3", 22, 0));
            //_studentList.Add(new Student("Vasya4", "Smolin4", 21, 0));
            //_studentList.Add(new Student("Vasya5", "Smolin5", 20, 0));

            //_studentList.Add(new Student("Dima1", "Petrushin1", 24, 0));
            //_studentList.Add(new Student("Dima2", "Petrushin2", 23, 0));
            //_studentList.Add(new Student("Dima3", "Petrushin3", 22, 0));
            //_studentList.Add(new Student("Dima4", "Petrushin4", 21, 0));
            //_studentList.Add(new Student("Dima5", "Petrushin5", 20, 0));

            //_studentList.Add(new Student("Vanya1", "Petkin1", 24, 0));
            //_studentList.Add(new Student("Vanya2", "Petkin2", 23, 0));
            //_studentList.Add(new Student("Vanya3", "Petkin3", 22, 0));
            //_studentList.Add(new Student("Vanya4", "Petkin4", 21, 0));
            //_studentList.Add(new Student("Vanya5", "Petkin5", 20, 0));

            //_studentList.Add(new Student("Slavik1", "Lebedev1", 24, 0));
            //_studentList.Add(new Student("Slavik2", "Lebedev2", 23, 0));
            //_studentList.Add(new Student("Slavik3", "Lebedev3", 22, 0));
            //_studentList.Add(new Student("Slavik4", "Lebedev4", 21, 0));
            //_studentList.Add(new Student("Slavik5", "Lebedev5", 20, 0));
        }

        public static Student[] GetStudents()
        {
            return _studentList.ToArray();
        }

        public static void AddStudent()
        {
            var newStudent = new Student("", "", 0, 0);

            Console.WriteLine("Give a name of a student:");
            newStudent.Name = Console.ReadLine();

            Console.WriteLine("Give a surname of a student:");
            newStudent.Surname = Console.ReadLine();

            Console.WriteLine("Give an age of a student:");

            //Person class has two different properties: string TestAge and int Age. TestAge is internal class. I assign to TestAge what user types
            //into the programm. "set" method checks for pure integer values and if they are not integer - it returns an error and asks to try again.
            //after correct value was defined for TestAge I transfer it to Age so I can use it later on.

            newStudent.TestAge = Console.ReadLine();
            newStudent.Age = int.Parse(newStudent.TestAge);

            //When new Student is created he doesn't have a group yet and has to be assigned.
            _studentList.Add(newStudent);
        }

        public static void ShowStudents()
        {
            Console.WriteLine("All Students:");
            for (int i = 0; i < StudentList.GetStudents().Length; i++)
            {
                Console.WriteLine($"N: {i + 1}, Name: {StudentList.GetStudents()[i].Name}, Surname: {StudentList.GetStudents()[i].Surname}, Age: {StudentList.GetStudents()[i].Age}, " +
                    $"Group: {((StudentList.GetStudents()[i].GroupNumb == 0) ? "Not assigned yet" : $"{StudentList.GetStudents()[i].GroupNumb}")}");
            }
        }
    }
}
