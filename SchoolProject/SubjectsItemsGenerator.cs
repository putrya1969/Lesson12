using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    
    internal class SubjectsItemsGenerator
    {
        public List<Subject> AvailabelSubjects { get; set; }
        public int LessonPerDay { get; set; }
        public List<SubjectItem> SubjectItems { get; set; } = new List<SubjectItem>();
        public Random Random { get; set; }

        public ScheduleItem ScheduleItem { get; set; }

        public SubjectsItemsGenerator(int lessonPerDay, List<Subject> subjects, Random random)
        {
            LessonPerDay = lessonPerDay;
            AvailabelSubjects = subjects;
            Random = random;
            CreateScheduleItem();
        }

        private void CreateScheduleItem()
        {
            for (int i = 0; i < LessonPerDay; i++)
            {
                CreateSubjectItem();
            }
        }

        private void CreateSubjectItem()
        {
            bool Exists = false;
            do
            {
                Subject subject = AvailabelSubjects[Random.Next(0, AvailabelSubjects.Count - 1)];
                if ((SubjectItems.Count > 0) && (SubjectItems.Where(s => s.SubjectName.Contains(subject.SubjectName)).ToList().Count > 0))
                    Exists = true;
                else
                {
                    int teacherPosition = 0;
                    if (subject.Teachers.Count > 1)
                        teacherPosition = Random.Next(0, subject.Teachers.Count - 1);
                    SubjectItems.Add(new SubjectItem(subject.SubjectName, subject.Teachers[teacherPosition]));
                    Exists = false;
                }
            } while (Exists);
        }
    }
}
