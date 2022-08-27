using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public class ScheduleItem
    {
        public int DayNumber { get; set; }
        public List<SubjectItem> SubjectItems { get; set; }
        public ScheduleItem(int dayNumber, List<SubjectItem> subjectItems)
        {
            DayNumber = dayNumber;
            SubjectItems = subjectItems;
        }
    }
}