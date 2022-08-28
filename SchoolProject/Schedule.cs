using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    internal class Schedule
    {
        public string Name { get; set; }
        internal List<ScheduleItem> ScheduleItems { get; set; } = new List<ScheduleItem>();

        internal Schedule(string name, List<ScheduleItem> scheduleItems)
        {
            Name = name;
            ScheduleItems = scheduleItems;
        }

        public void Print()
        {
            Console.WriteLine($"{Name}");
            foreach (ScheduleItem item in ScheduleItems)
            {
                Console.WriteLine($"Day {item.DayNumber + 1}");
                for (int i = 0; i < item.SubjectItems.Count; i++)
                {
                    Console.WriteLine($"{item.SubjectItems[i].SubjectName} - {item.SubjectItems[i].Teacher.LastName} {item.SubjectItems[i].Teacher.FirstName}");
                }
            }
        }
    }
}