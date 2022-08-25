using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    class School
    {

        public LearningStream[] LearnStreams { get; set;}

        public School(int CountOfStreams)
        {
            LearnStreamsInit(CountOfStreams);
        }

        private void LearnStreamsInit(int CountOfStreams)
        {
            LearnStreams = new LearningStream[CountOfStreams];
            for (int i = 0; i < this.LearnStreams.Length; i++)
            {
                var learnStream = new LearningStream(4);
                char classLetter = 'A';
                var asciiCode = classLetter;
                for (int j = 0; j < learnStream.Classes.Length; j++)
                {
                    learnStream.Classes[j] = new StudyClass($"{i + 1}-{Char.ConvertFromUtf32(65 + j)}");
                }
                LearnStreams[i] = learnStream;
            }
        }
    }
}