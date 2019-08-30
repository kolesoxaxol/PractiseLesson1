using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humans;

namespace VasylTravinHomeWork9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"{Humans.Groups.GroupList.GetGroups()[1].studentCount}");
            Humans.HumansLibrary.StudentList.ShowStudents();
            Humans.Groups.GroupList.Distribute();

            Humans.HumansLibrary.StudentList.ShowStudents();

            Humans.Groups.GroupList.ShowGroups(1);

            Humans.Groups.GroupList.ShowGroups(2);
            Console.ReadKey();
        }
    }
}
