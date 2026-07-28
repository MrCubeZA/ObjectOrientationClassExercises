using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ObjectOrientationClassExercises.Inheritance
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public Race Race { get; set; }
        public bool Deceased { get; set; }



        public string FullName
        {
            get { return $"{FirstName} {Surname}"; }
        }

        public Person(string firstName, string surname, Gender gender, Race race, int age, bool deceased)
        {
            FirstName = firstName;
            Surname = surname;
            Gender = gender;
            Race = race;
            Age = age;
            Deceased = deceased;
        }
    }

} 
        



