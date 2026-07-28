using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Inheritance
{
    internal class Pilot  : Employee
    {
        public Pilot(bool licensed, double hoursFlown, FlyingType flyingType, string employeeNumber, decimal salary, string occupation, string company, string taxNumber, EmploymentType employmentType, string firstName, string surname, Gender gender, Race race, int age, bool deceased) : base(employeeNumber, salary, occupation, company, taxNumber, employmentType, firstName, surname, gender, race, age, deceased)
        {
            Licensed = licensed;
            HoursFlown = hoursFlown;
            FlyingType = flyingType;   

        }

        public bool Licensed { get; set; }
        public double HoursFlown { get; set; }
        public FlyingType FlyingType { get; set; }

    }
}
