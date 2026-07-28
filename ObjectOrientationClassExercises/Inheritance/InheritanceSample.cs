using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Inheritance
{
    internal class InheritanceSample
    {


        public static void Run()
        {
            List<Person> people = new List<Person>();



            Person person = new Person("Bobby", "Jones", Gender.Male, Race.Coloured, 21, false);

            people.Add(person);


            Student student = new Student("12355", "8", "Computet Science", "UWC", 5, "Samantha", "Pieterse", Gender.Female, Race.NotSpecified, 28, true);

            people.Add(student);


            Employee employee = new Employee("1234", 3000000, "Programmer", "BitCoin Inc", "A1002", EmploymentType.FullTime, "Elon", "Musnt", Gender.Other, Race.White, 45, false);

            people.Add(employee);

            Pilot pilot = new Pilot(true, 10, FlyingType.Fighter, "85575", 12000, "Military Pilot", "US SpaceForce", "A12312", EmploymentType.Contract, "Simone", "Gates", Gender.Male, Race.White, 25, true);

            people.Add(pilot);


            Console.WriteLine("These are the people that are Full Time Employed: ");

            foreach (Person singlePerson in people)
            {
                if (singlePerson is Employee)
                {
                    Employee singleEmployee = singlePerson as Employee;

                    if (singleEmployee.EmploymentType == EmploymentType.FullTime)
                    {
                        Console.WriteLine($"Full Name: {singlePerson.FullName} ");
                    }

                }


            }
        }
    }
}