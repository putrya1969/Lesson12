using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public class ScheduleItem
    {
        public WorkDayOfWeek NameOfDay { get; set; }
        public List<SubjectName> SubjectsForDay { get; set; }
        public ScheduleItem(WorkDayOfWeek nameOfDay, List<SubjectName> subjectsForDay)
        {
            NameOfDay = nameOfDay;
            SubjectsForDay = subjectsForDay;
        }
    }

    public enum WorkDayOfWeek
    { 
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
}