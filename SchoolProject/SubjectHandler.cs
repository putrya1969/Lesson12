using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    internal class SubjectHandler : IDisposable
    {

        public Teacher[] Teachers { get; set; }
        public List<Subject> Subjects { get; set; }
        public SubjectHandler(Teacher[] teachers)
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
            var subjects = new List<Subject>();
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
