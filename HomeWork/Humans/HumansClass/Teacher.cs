using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans.HumansClass
{
    public class Teacher : Person
    {
        public Teacher(string name, string surname, int age, int academyLevel) : base(name, surname, age)
        {
            this.AcademyLevel = academyLevel;
        }

        public int AcademyLevel { get; set; }

    }
}
