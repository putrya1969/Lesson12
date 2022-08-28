using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    internal class ScheduleItem
    {
        internal int DayNumber { get; set; }
        internal List<SubjectItem> SubjectItems { get; set; }
        internal ScheduleItem(int dayNumber, List<SubjectItem> subjectItems)
        {
            DayNumber = dayNumber;
            SubjectItems = subjectItems;
        }
    }
}