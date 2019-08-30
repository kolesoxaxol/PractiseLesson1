using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humans.HumansClass;
using Humans.HumansLibrary;

namespace Humans.Groups
{
    public class Group
    {
        public Group(Teacher teacher, Student[] students)
        {
            this.TTeacher = teacher;
            this.SStudents = students;
        }

        public Teacher TTeacher { get; set; }
        public Student[] SStudents { get; set; }

    }
}
