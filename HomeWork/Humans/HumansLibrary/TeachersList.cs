using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humans.HumansClass;

namespace Humans.HumansLibrary
{
    public static class TeachersList
    {
        static List<Teacher> _teacherList;

        static TeachersList()
        {
            _teacherList = new List<Teacher>();

            _teacherList.Add(new Teacher("Nameless", "Apprentice", 100, 1));
            _teacherList.Add(new Teacher("TheDark", "One", 100, 1));
            _teacherList.Add(new Teacher("Vladimir", "Drakula", 587, 3));
        }

        public static Teacher[] GetTeachers()
        {
            return _teacherList.ToArray();
        }

        public static void ShowTeachers()
        {
            Console.WriteLine("Teachers:");
            for (int i = 0; i < TeachersList.GetTeachers().Length; i++)
            {
                Console.WriteLine($"N: {i + 1}, Name: {TeachersList.GetTeachers()[i].Name}, Surname: {TeachersList.GetTeachers()[i].Surname}, Age: {TeachersList.GetTeachers()[i].Age}, Group: {i + 1}");
            }
        }
    }
}
