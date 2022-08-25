using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public class Subject
    {
        public string Name { get; set; }

        //public int QtyPerWeek { get; set; }
        public Subject(string name)
        {
            Name = name;
        }
    }
}