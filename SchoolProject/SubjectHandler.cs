using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class SubjectHandler : IDisposable
    {

        internal List<Teacher> Teachers { get; set; }
        internal List<Subject> Subjects { get; set; }
        internal SubjectHandler(List<Teacher> teachers)
        {
            Teachers = teachers;
            Subjects = SubjectsInit();
        }

        private List<string> GetSubjectNamesByTeachers()
        {
            var subjectNames = new List<SubjectName>();
            foreach (var item in Teachers)
            {
                subjectNames.AddRange(item.SubjectsNames);
            }
            return subjectNames.Select(s => s.Name).ToList();
        }
        private List<Teacher> GetTeacherBySubject(string subjectName)
        {
            return Teachers.Where(t => t.SubjectsNames.Select(x => x.Name).Contains(subjectName)).ToList();
        }

        private List<Subject> SubjectsInit()
        {
            List<Subject> subjects = new List<Subject>();
            var currentSubjectsNames = GetSubjectNamesByTeachers().Distinct().ToList();
            foreach (var item in currentSubjectsNames)
            {
                Subject subject = new Subject(item, GetTeacherBySubject(item));
                subjects.Add(subject);
            }
            return subjects;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
