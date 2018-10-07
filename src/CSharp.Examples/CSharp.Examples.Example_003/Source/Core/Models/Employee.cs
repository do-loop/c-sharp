using System;

namespace CSharp.Examples.Example_003.Source.Core.Models
{
    internal struct Employee
    {
        public string City { get; set; }
        public string HomeCity { get; set; }

        public string Name { get; }
        public int Age { get; }
        public DateTime BirthDate { get; }

        public Employee(string city, string homeCity, string name, int age, DateTime date)
        {
            City = city;
            HomeCity = homeCity;
            Name = name;
            Age = age;
            BirthDate = date;
        }
    }
}