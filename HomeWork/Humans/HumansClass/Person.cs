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
        internal int _age;
        internal string _testAge;


        internal Person(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; internal set; }

        public string Surname { get; internal set; }

        //I've tried to play with properties and incapsulation. There I want to make sure user provides correct value for Age, i.e int value.
        //For this reason I've created internal class TestAge that will check for correct user input. I can activate "set"er of TestAge 
        //via Console.ReadLine() and perform all validations inside internal property TestAge. After everuthing is correct, I can transfer value of
        //TestAge to Age later in the programm (see StudentList.AddStudent() ).

        public int Age
        {
            get
            {
                return _age;
            }
            internal set
            {
               
                _age = value;
            }
        }


        internal string TestAge
        {
            get
            {
                return _testAge;
            }
            set
            {
                int result;
                string input = value.ToString();
                while (!int.TryParse(input, out result))
                {
                    Console.WriteLine("Enter integer value!");
                    input = Console.ReadLine();
                }
                _testAge = result.ToString();
            }
        }
    }
}
