namespace Library
{
    public class Student
    {
        private string name = string.Empty;
        private string lastName = string.Empty;

        public Student(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

        public string Name { get { return name; } set { name = value; } }

        public override string ToString()
        {
            return $"Student: {name} {lastName}";
        }
    }
}
