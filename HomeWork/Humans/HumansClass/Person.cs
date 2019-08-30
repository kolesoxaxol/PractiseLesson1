using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans.HumansClass
{
    public abstract class Person
    {
         internal Person(string name, string surname, int age)
        {
            this.ID = Guid.NewGuid();
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public Guid ID { get; private set; }
        public string Name { get; }

        public string Surname { get; }

        public int Age { get; set; }
    }
}
