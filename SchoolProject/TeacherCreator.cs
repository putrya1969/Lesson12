using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class TeacherCreator
    {
        public string[] FirstNames { get; }
        public string[] LastNames { get; }
        public string[] SubjectsNames { get; }
        public Random RandomNumber { get; }
        public TeacherCreator(string[] firstNames, string[] lastNames, string[] subjectsNames, Random randomNumber)
        {
            FirstNames = firstNames;
            LastNames = lastNames;
            SubjectsNames = subjectsNames;
            RandomNumber = randomNumber;
        }

        public Teacher CreateTeacher()
        {
            return new Teacher(GetFirstName(RandomNumber.Next(0, LastNames.Length - 1)),
                GetLastName(RandomNumber.Next(0, FirstNames.Length - 1)),
                CreateBirthDate(),
                CreateSubjects());
        }

        private string GetFirstName(int index)
        {
            return FirstNames[index];
        }

        private string GetLastName(int index)
        {
            return LastNames[index];
        }

        private DateTime CreateBirthDate()
        {
            var year = RandomNumber.Next(1960, 2000);
            var month = RandomNumber.Next(1, 12);
            int day;
            if (month == 2)
                day = RandomNumber.Next(1, 28);
            else if ((month == 4) || (month == 6) || (month == 9) || (month == 11))
                day = RandomNumber.Next(1, 30);
            else
                day = RandomNumber.Next(1, 31);
            return new DateTime(year, month, day);
        }

        private Subject[] CreateSubjects()
        {
            var countSubjects = RandomNumber.Next(1, 3);
            var subjects = new Subject[countSubjects];
            for (int i = 0; i < subjects.Length; i++)
            {
                var subjIndex = RandomNumber.Next(0, SubjectsNames.Length - 1);
                subjects[i] = new Subject(SubjectsNames[subjIndex]);
            }
            return subjects;
        }
    }
}
