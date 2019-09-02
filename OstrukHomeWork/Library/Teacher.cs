namespace Library
{
    public class Teacher
    {
        private string type = string.Empty;

        public Teacher(string type)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return $"Teacher: {type}";
        }
    }
}
