using System.Collections.Generic;

namespace SchoolProject
{
    public class StudyClass
    {
        public int StreamNumber { get; }
        public string Name { get; set; }
        public int CountOfPupils { get; set; }
        public Teacher Teacher { get; set; }

        public List<Pupil> Pupils { get; set; }


        public StudyClass(int streamNumber, string name, int countOfPupils)
        {
            StreamNumber = streamNumber;
            Name = name;
            CountOfPupils = countOfPupils;
        }
    }
}