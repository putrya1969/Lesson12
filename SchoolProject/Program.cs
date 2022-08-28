using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To create a school\nEnter number of streams");
            int CountOfStreams = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of classes on stream");
            int CountClassesOnStream = int.Parse(Console.ReadLine());
            var school = new School(CountOfStreams, CountClassesOnStream);
            Console.Clear();
            Console.WriteLine("Our school has the following classes");
            Console.WriteLine(GetAllClassNames(school));
            Console.WriteLine("To view information about a class, enter the class name without quotes");
            var className = Console.ReadLine();
            Console.Clear();
            PrintClassInfo(GetClassByName(school, className));
            Console.ReadKey();
        }

        static StudyClass GetClassByName(School school, string className)
        {
            int index = int.Parse(className.Substring(0, 1));
            LearningStream learningStream = school.LearnStreams[index - 1];
            foreach (var item in learningStream.Classes)
            {
                if (item.Name == className)
                {
                    return item;
                }
            }
            return null;
        }

        static void PrintClassInfo(StudyClass studyClass)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class: {studyClass.Name}");
            sb.AppendLine($"Teacher: {studyClass.Teacher.LastName} {studyClass.Teacher.FirstName}");
            sb.AppendLine($"Count of pupils: {studyClass.CountOfPupils}");
            sb.AppendLine($"Pupils :");
            foreach (var pupil in studyClass.Pupils)
            {
                sb.Append($"{pupil.LastName} {pupil.FirstName.Substring(0, 1)}. \t");
            }
            sb.AppendLine();
            Console.WriteLine(sb);
            studyClass.Schedule.Print();
        }

        static string GetAllClassNames(School school)
        {
            string result = string.Empty;
            foreach (var item in school.LearnStreams)
            {
                var classes = item.Classes;
                foreach (var studyClass in classes)
                {
                    result += $"'{studyClass.Name}' ";
                }
            }
            return result;
        }
    }
}
