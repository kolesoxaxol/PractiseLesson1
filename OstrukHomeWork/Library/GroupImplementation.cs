using System;

namespace Library
{
    partial class Group
    {
        public Group(string GroupName, string teacherType)
        {
            this.GroupName = GroupName;
            teacher = new Teacher(teacherType);
            switch (teacherType)
            {
                case "Assistant Professor":
                    students = new Student[20];
                    break;
                case "Lecturer":
                    students = new Student[15];
                    break;
                case "Assistant":
                    students = new Student[5];
                    break;
            }
        }

        public string Add(Student student)
        {
            if (Size < students.Length)
            {
                students[Size] = student;
                Size++;
                return "";
            }
            else
            {
                Size = 0;
                return $"{GroupName} is overload!";
            }
        }

        public void PrintGroup()
        {
            Console.WriteLine($"Group: {GroupName}, teacher: {teacher}");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
