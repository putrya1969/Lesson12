using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    internal class SchedulesGenerator : IDisposable
    {
        public List<LearningStream> LearningStreams { get; }
        public List<Subject> Subjects { get; }

        internal SchedulesGenerator(List<LearningStream> learningStreams, List<Subject> subjects)
        {
            LearningStreams = learningStreams;
            Subjects = subjects;
            Generate();
        }

        private void Generate()
        {
            foreach (var learningStream in LearningStreams)
            {
                var studyClasses = learningStream.Classes;
                foreach (var studyClass in studyClasses)
                {
                    studyClass.Schedule = ScheduleCreator.Create(studyClass, 5, Subjects, School.Random);
                }
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
