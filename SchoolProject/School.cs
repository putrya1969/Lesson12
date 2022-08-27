using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    class School 
    {
        public static Random Random = new Random();

        public static string[] FirstNames;

        public static string[] LastNames;

        public static string[] SubjectsNames;
        public LearningStream[] LearnStreams { get; set;}
        public Teacher[] Teachers { get; set; }
        internal List<Subject> Subjects { get; set; }

        static School()
        {
            FirstNames = new FileHandler(Path.Combine(Environment.CurrentDirectory, "FirstNames.txt")).Content;
            LastNames = new FileHandler(Path.Combine(Environment.CurrentDirectory, "LastNames.txt")).Content;
            SubjectsNames = new FileHandler(Path.Combine(Environment.CurrentDirectory, "SubjectsNames.txt")).Content;
        }

        public School()
        {
            Console.WriteLine("Enter number of streams");
            int CountOfStreams = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of classes on stream");
            int CountClassesOnStream = int.Parse(Console.ReadLine());
            TeachersInit(CountOfStreams * CountClassesOnStream);
            LearnStreamsInit(CountOfStreams, CountClassesOnStream);
            using (SubjectHandler subjectHandler = new SubjectHandler(Teachers)){ Subjects = subjectHandler.Subjects; }
        }
        private void LearnStreamsInit(int CountOfStreams, int CountClassesOnStream)
        {
            LearnStreams = new LearningStream[CountOfStreams];
            for (int i = 0; i < this.LearnStreams.Length; i++)
            {
                var learnStream = new LearningStream(CountClassesOnStream);
                for (int j = 0; j < learnStream.Classes.Length; j++)
                {
                    int streamNumber = i + 1;
                    int classPosition = j;
                    string className = GetClassName(streamNumber,classPosition);
                    int countOfPupil = 25;
                    learnStream.Classes[j] = CreateClass(streamNumber, className, countOfPupil);
                }
                LearnStreams[i] = learnStream;
            }
            TeachersAppointment();
        }
        private void TeachersInit(int NumberOfTeachers)
        {
            Teachers = new TeachersGenerator(NumberOfTeachers).Teachers;
        }

        private StudyClass CreateClass(int streamNum, string className, int numberOfPupils)
        {
            return new StudyClass(streamNum, className, numberOfPupils);
        }

        private string GetClassName(int streamNumber, int classPosition)
        {
            return $"{streamNumber}-{Char.ConvertFromUtf32(65 + classPosition)}";
        }

        private void TeachersAppointment()
        {
            int teacherIndex = 0;
            for (int i = 0; i < LearnStreams.Length; i++)
            {
                var learnStream = LearnStreams[i];
                for (int j = 0; j < learnStream.Classes.Length; j++)
                {
                    learnStream.Classes[j].Teacher = Teachers[teacherIndex];
                    Teachers[teacherIndex].Class = learnStream.Classes[j];
                    teacherIndex++;
                }
            }
        }
    }
}