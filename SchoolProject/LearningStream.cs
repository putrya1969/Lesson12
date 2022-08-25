using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public class LearningStream
    {
        public StudyClass[] Classes { get; set; }

        public LearningStream(int NumberOfStudyClass)
        {
            Classes = new StudyClass[NumberOfStudyClass];
        }
    }
}