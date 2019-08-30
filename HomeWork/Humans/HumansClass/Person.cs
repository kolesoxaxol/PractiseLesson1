using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans.HumansClass
{
    //Creating a class Person which shares similar proterties between Student and Teacher.
    //Originaly there was a Guid property which I wanted to use as an indificator during students distribution between different groups. 
    //During the Distribution Method coding I had found another way to check for already assigned students, so I got rid off Guid property.
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
