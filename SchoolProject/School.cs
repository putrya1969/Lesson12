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
        public List<LearningStream> LearnStreams { get; private set; }
        public List<Teacher> Teachers { get; private set; }
        public List<Subject> Subjects { get; private set; }

        static School()
        {
            FirstNames = new FileHandler(Path.Combine(Environment.CurrentDirectory, "FirstNames.txt")).Content;
            LastNames = new FileHandler(Path.Combine(Environment.CurrentDirectory, "LastNames.txt")).Content;
            SubjectsNames = new FileHandler(Path.Combine(Environment.CurrentDirectory, "SubjectsNames.txt")).Content;
        }

        public School(int countOfStreams, int countClassesOnStream)
        {
            using (TeachersGenerator teachersGenerator = new TeachersGenerator(countOfStreams * countClassesOnStream)) 
            { Teachers = teachersGenerator.Teachers; }
            using (LearnStreamGenerator learnStreamGenerator = new LearnStreamGenerator(countOfStreams, countClassesOnStream))
            { LearnStreams = learnStreamGenerator.LearningStreams; }
            TeachersAppointment();
            using (SubjectHandler subjectHandler = new SubjectHandler(Teachers)){ Subjects = subjectHandler.Subjects; }
            using (SchedulesGenerator schedulesGenerator = new SchedulesGenerator(LearnStreams, Subjects)){ }
        }

        private void TeachersAppointment()
        {
            int teacherIndex = 0;
            for (int i = 0; i < LearnStreams.Count; i++)
            {
                var learnStream = LearnStreams[i];
                for (int j = 0; j < learnStream.Classes.Count; j++)
                {
                    learnStream.Classes[j].Teacher = Teachers[teacherIndex];
                    Teachers[teacherIndex].Class = learnStream.Classes[j];
                    teacherIndex++;
                }
            }
        }
    }
}