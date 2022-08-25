using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public class Child
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }
        public Child(string firstName, string lastName, DateTime birthDay) : this(firstName, lastName, birthDay, DateTime.Now.Year - birthDay.Year) { }

        public Child(string firstName, string lastName, DateTime birthDay, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Age = age;
        }

    }
}