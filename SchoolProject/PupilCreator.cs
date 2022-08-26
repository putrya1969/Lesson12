using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public static class PupilCreator
    {
        public static Pupil CreatePupil(string studyClass, Child child)
        {
            return new Pupil(studyClass, child.FirstName, child.LastName, child.BirthDay);
        }
    }
}
