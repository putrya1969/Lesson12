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
        public Schedule Schedule { get; set; }

        public StudyClass(int streamNumber, string name, int countOfPupils)
        {
            StreamNumber = streamNumber;
            Name = name;
            CountOfPupils = countOfPupils;
            Pupils = new List<Pupil>();
            GetPupils(ChildrenCreate());
        }

        private void GetPupils(List<Child> children)
        {
            foreach (var item in children)
            {
                Pupils.Add(PupilCreator.CreatePupil(Name, item));
            }
        }

        private List<Child> ChildrenCreate()
        {
            return ChildrenGenerator.Generate(CountOfPupils, StreamNumber);
        }
    }
}