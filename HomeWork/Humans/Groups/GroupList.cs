using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humans.HumansClass;
using Humans.HumansLibrary;
using Validation;

namespace Humans.Groups
{


    public static class GroupList
    {
        public static int Overload(int studentsCount1, int studentsCount2, int studentsCount3, int groupSize1, int groupSize2, int groupSize3)
        {
            int groupNumb;
            while (true)
            {
                groupNumb = Input.Validation(3, "Please, select a group number you want to add this Student to. Select \"0\" if you want to select another student.");
                if (groupNumb == 1 && studentsCount1 == groupSize1)
                {
                    Console.WriteLine("This group is full. Select another one!\n");
                }
                else if (groupNumb == 2 && studentsCount2 == groupSize2)
                {
                    Console.WriteLine("This group is full. Select another one!\n");
                }
                else if (groupNumb == 3 && studentsCount3 == groupSize3)
                {
                    Console.WriteLine("This group is full. Select another one!\n");
                }
                else if (groupNumb == 0)
                {
                    //nothing happence there, cycle continues.
                }
                else
                {
                    break;
                }
            }

            return groupNumb;
        }

        public static void DistMessage(int group, Student student)
        {
            Console.WriteLine($"You assigned student Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age} to a group Number {group}");
        }

        static Student[] _groupNum1;
        static Student[] _groupNum2;
        static Student[] _groupNum3;

        static GroupList()
        {
            _groupNum1 = new Student[5];
            _groupNum2 = new Student[15];
            _groupNum3 = new Student[20];
        }

        public static void Distribute()
        {
            var allStudents = new Student[StudentList.GetStudents().Length];

            for (int i = 0; i < StudentList.GetStudents().Length; i++)
            {
                allStudents[i] = StudentList.GetStudents()[i];
            }

            int studentCount1 = 0;
            int studentCount2 = 0;
            int studentCount3 = 0;

            while (studentCount1 + studentCount2 + studentCount3 < StudentList.GetStudents().Length)
            {

                int studentNum = Input.Validation(StudentList.GetStudents().Length - 1, "Select number N of a student you want to assign to a specific group.");
                while (allStudents[studentNum] == null)
                {
                    studentNum = Input.Validation(StudentList.GetStudents().Length - 1, "This student has been assigned to another group already. Please, select another one.");
                }

                int groupNum = Overload(studentCount1, studentCount2, studentCount3, 5, 15, 20);

                switch (groupNum)
                {
                    case 1:
                        {


                            DistMessage(groupNum, allStudents[studentNum]);
                            _groupNum1[studentCount1] = allStudents[studentNum];
                            allStudents[studentNum] = null;
                            StudentList.GetStudents()[studentNum].GroupNumb = 1;
                            studentCount1++;
                            break;

                        }
                    case 2:
                        {

                            DistMessage(groupNum, allStudents[studentNum]);
                            _groupNum2[studentCount2] = allStudents[studentNum];
                            allStudents[studentNum] = null;
                            StudentList.GetStudents()[studentNum].GroupNumb = 1;
                            studentCount2++;
                            break;
                        }
                    case 3:
                        {

                            DistMessage(groupNum, allStudents[studentNum]);
                            _groupNum3[studentCount3] = allStudents[studentNum];
                            allStudents[studentNum] = null;
                            StudentList.GetStudents()[studentNum].GroupNumb = 1;
                            studentCount3++;
                            break;
                        }
                    case 0:
                        {
                            break;
                        }
                }
            }

        }

        public static Group[] GetGroups()
        {
            var tempGroup = new Group[3];
            tempGroup[0] = new Group(TeachersList.GetTeachers()[0], _groupNum1);
            tempGroup[1] = new Group(TeachersList.GetTeachers()[1], _groupNum2);
            tempGroup[2] = new Group(TeachersList.GetTeachers()[2], _groupNum3);
            return tempGroup;
        }

        public static void ShowGroups(int groupNumb)
        {
            Console.WriteLine($"Detailed information about group number {groupNumb}:\n");
            Console.WriteLine($"Teacher: {GroupList.GetGroups()[groupNumb - 1].TTeacher},");
            for (int i = 0; i < GroupList.GetGroups()[groupNumb - 1].SStudents.Length ; i++)
            {
                if(GroupList.GetGroups()[groupNumb - 1].SStudents[i] != null)
                {
                    Console.WriteLine($"N: {i}, Name: {GroupList.GetGroups()[groupNumb - 1].SStudents[i].Name}, Surname: {GroupList.GetGroups()[groupNumb - 1].SStudents[i].Surname}, Age: {GroupList.GetGroups()[groupNumb - 1].SStudents[i].Age}.");
                }
            }
        }
    }
}
