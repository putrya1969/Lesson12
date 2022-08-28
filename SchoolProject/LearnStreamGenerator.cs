using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    internal class LearnStreamGenerator : IDisposable
    {
        internal List<LearningStream> LearningStreams { get; set; } = new List<LearningStream>();
        internal LearnStreamGenerator(int countOfStreams, int countClassesOnStream)
        {
            for (int i = 0; i < countOfStreams; i++)
            {
                var learnStream = new LearningStream();
                for (int j = 0; j < countClassesOnStream; j++)
                {
                    int streamNumber = i + 1;
                    int classPosition = j;
                    string className = $"{streamNumber}-{Char.ConvertFromUtf32(65 + classPosition)}";
                    int countOfPupil = 25;
                    learnStream.Classes.Add(CreateClass(streamNumber, className, countOfPupil));
                }
                LearningStreams.Add(learnStream);
            }
        }
        private StudyClass CreateClass(int streamNum, string className, int numberOfPupils)
        {
            return new StudyClass(streamNum, className, numberOfPupils);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
