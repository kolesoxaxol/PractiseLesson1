namespace Library
{
    public partial class Group
    {
        public static int Size = 0;
        private Teacher teacher;
        private Student[] students;
        public string GroupName = string.Empty;
        public Student[] Students { get {  return students; } set { students = value; } }
    }
}
