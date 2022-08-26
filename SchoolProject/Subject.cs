using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class Subject
    {
        public string SubjectName { get; }
        public List<Teacher> Teachers { get; set; }
        public Subject(string subjectName, List<Teacher> teachers)
        {
            SubjectName = subjectName;
            Teachers = teachers;
        }
    }
}
