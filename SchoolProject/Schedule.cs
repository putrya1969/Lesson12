using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public class Schedule
    {
        public string Name { get; set; }
        public List<ScheduleItem> ItemsForWeek { get; set; }

        public Schedule(StudyClass studyClass)
        {
            Name = $"Schedule for {studyClass.Name} class";
        }
    }
}