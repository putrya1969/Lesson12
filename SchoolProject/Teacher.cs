using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public class Teacher : Employee
    {
        public @string Class { get; set; }

        public Subject[] Subjects { get; set; }

        public Teacher(string firstName, string lastName, DateTime birthDay, Subject[] subjects) : base (firstName, lastName, birthDay)
        {
            Subjects = subjects;
        }
    }
}