using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    internal class SubjectItem
    {
        public string SubjectName { get; set; }
        internal Teacher Teacher { get; set; }
        internal SubjectItem(string subjectName, Teacher teacher)
        {
            SubjectName = subjectName;
            Teacher = teacher;
        }
    }
}
