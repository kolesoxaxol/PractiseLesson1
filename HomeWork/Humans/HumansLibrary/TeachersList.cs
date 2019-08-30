﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humans.HumansClass;

namespace Humans.HumansLibrary
{
    public static class TeachersList
    {
        static List<Teacher> _teacherList;

        static TeachersList()
        {
            _teacherList = new List<Teacher>();

            _teacherList.Add(new Teacher("Nameless", "Apprentice", 100, 1));
            _teacherList.Add(new Teacher("The Dark", "One", 300, 2));
            _teacherList.Add(new Teacher("Vladimir", "Drakula", 587, 3));
        }

        public static Teacher[] GetTeachers()
        {
            return _teacherList.ToArray();
        }
    }
}
