using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    internal static class ScheduleCreator
    {
        const int daysWeek = 5;
        internal static Schedule Create (StudyClass studyClass, int lessonsOerDay, List<Subject> subjects, Random random)
        {
            List<ScheduleItem> scheduleItems = new List<ScheduleItem>();
            string name = $"Schedule for {studyClass.Name} class";
            for (int i = 0; i < daysWeek; i++)
            {
                scheduleItems.Add(new ScheduleItem(i, new SubjectsItemsGenerator(lessonsOerDay, subjects, random).SubjectItems));
            }
            return new Schedule(name, scheduleItems);
        }
    }
}
