using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public class Teacher : Employee
    {
        public StudyClass Class { get; set; }

        public SubjectName[] SubjectsNames { get; set; }

        public Teacher(string firstName, string lastName, DateTime birthDay, SubjectName[] subjectsNames) : base (firstName, lastName, birthDay)
        {
            SubjectsNames = subjectsNames;
        }
    }
}