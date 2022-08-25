using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public class Child
    {
        public string FirstName
        {
            get => default;
            set
            {
            }
        }

        public string LastName
        {
            get => default;
            set
            {
            }
        }

        public DateTime BirthDay { get; }

        public int Age
        {
            get => default;
            set
            {
            }
        }

        public DateTime DateOfBirth
        {
            get => default;
            set
            {
            }
        }

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