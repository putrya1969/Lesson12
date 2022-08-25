using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class TeachersGenerator
    {
        public Teacher[] Teachers { get; set; }
        public TeachersGenerator(int countTeachers)
        {
            Teachers = new Teacher[countTeachers];
            for (int i = 0; i < countTeachers; i++)
            {
                Teachers[i] = new TeacherCreator(School.FirstNames, School.LastNames, School.SubjectsNames, School.Random).CreateTeacher();
            }
        }
    }
}
