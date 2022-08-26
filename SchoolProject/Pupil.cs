using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public class Pupil : Child
    {
        public string StudyClassName { get; set; }

     
        public Pupil(string studyClassName, string firstName, string lastName, DateTime birthDay) : base(firstName, lastName, birthDay)
        {
            StudyClassName = studyClassName;
        }
    }
}