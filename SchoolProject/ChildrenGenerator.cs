using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{

    internal class ChildrenGenerator
    {
        public List<Child> Children { get; set; } = new List<Child>();
        public ChildrenGenerator(int countOfChildren, int streamNumber)
        {
            for (int i = 0; i < countOfChildren; i++)
            {
                Children.Add(new ChildCreator(School.FirstNames, School.LastNames, School.Random, streamNumber).CreateChild());
            }
        }
    }
}
