using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public class Pupil : Child
    {
        public StudyClass StudyClass { get; set; }

     
        public Pupil(StudyClass studyClass, string firstName, string lastName, DateTime birthDay) : base(firstName, lastName, birthDay)
        {
            StudyClass = studyClass;
        }
    }
}