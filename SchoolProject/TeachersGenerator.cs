using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    internal class TeachersGenerator : IDisposable
    {
        internal List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public TeachersGenerator(int countTeachers)
        {

            for (int i = 0; i < countTeachers; i++)
            {
                Teachers.Add(new TeacherCreator(School.FirstNames, School.LastNames, School.SubjectsNames, School.Random).CreateTeacher());
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
