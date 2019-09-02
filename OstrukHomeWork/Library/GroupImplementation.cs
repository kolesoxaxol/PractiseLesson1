using System;

namespace Library
{
    partial class Group
    {
        public Group(string GroupName, string teacherType) // use cameCase for fields and UpperCase for Propety => groupName
        {
            this.GroupName = GroupName;
            teacher = new Teacher(teacherType);
            switch (teacherType)
            {
                case "Assistant Professor":  // переделай по свободке на Enum 
                    students = new Student[20];
                    break;
                case "Lecturer":
                    students = new Student[15];
                    break;
                case "Assistant":
                    students = new Student[5];
                    break;

                  // default? ? ? GroupName пришло "Professor" 
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
