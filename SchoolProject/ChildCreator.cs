
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    internal class ChildCreator
    {
        public string[] FirstNames { get; }
        public string[] LastNames { get; }
        public Random RandomNumber { get; }
        public int StreamNumber { get; }

        public ChildCreator(string[] firstNames, string[] lastNames, Random randomNumber, int streamNumber)
        {
            FirstNames = firstNames;
            LastNames = lastNames;
            RandomNumber = randomNumber;
            StreamNumber = streamNumber;
        }

        public Child CreateChild()
        {
            return new Child(GetFirstName(RandomNumber.Next(0, LastNames.Length - 1)),
                GetLastName(RandomNumber.Next(0, FirstNames.Length - 1)),
                CreateBirthDate());
        }

        private string GetFirstName(int index)
        {
            return FirstNames[index];
        }

        private string GetLastName(int index)
        {
            return LastNames[index];
        }

        private DateTime CreateBirthDate()
        {
            var year = RandomNumber.Next(DateTime.Now.Year - 7 - StreamNumber, DateTime.Now.Year - 6 - StreamNumber);
            var month = RandomNumber.Next(1, 12);
            int day;
            if(month==2)
                day = RandomNumber.Next(1, 28);
            else if ((month == 4) || (month==6)||(month==9)||(month==11))
                day = RandomNumber.Next(1, 30);
            else
                day = RandomNumber.Next(1, 31);
            return new DateTime(year, month, day);
        }

    }
}
