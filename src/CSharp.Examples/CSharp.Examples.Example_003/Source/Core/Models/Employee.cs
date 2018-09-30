using System;

namespace CSharp.Examples.Example_003.Source.Core.Models
{
    internal struct Employee
    {
        public string Name { get; }
        public int Age { get; }
        public DateTime BirthDate { get; }

        public Employee(string name, int age, DateTime date)
        {
            Name = name;
            Age = age;
            BirthDate = date;
        }
    }
}