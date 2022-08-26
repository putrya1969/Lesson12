using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public static class ChildrenGenerator
    {
        public static List<Child> Generate(int countOfChildren, int streamNumber)
        {
            List<Child> children = new List<Child>();
            for (int i = 0; i < countOfChildren; i++)
            {
                children.Add(new ChildCreator(School.FirstNames, School.LastNames, School.Random, streamNumber).CreateChild());
            }
            return children;
        }
    }
}
