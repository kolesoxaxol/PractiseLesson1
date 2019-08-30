using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans.HumansClass
{
    //Creating a class Person which shares similar proterties between Student and Teacher.
    public abstract class Person
    {
         internal Person(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; }

        public string Surname { get; }

        public int Age { get; set; }
    }
}
