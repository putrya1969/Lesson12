using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class SubjectItem
    {
        public string SubjectName { get; set; }
        public Teacher Teacher { get; set; }
        public SubjectItem(string subjectName, Teacher teacher)
        {
            SubjectName = subjectName;
            Teacher = teacher;
        }
    }
}
