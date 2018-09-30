using System;

namespace CSharp.Examples.Example_002.Source.Core.Models
{
    internal class SpecificEmployee : Employee
    {
        public DateTime BirthDate { get; set; } = DateTime.Now;

        public SpecificEmployee(string name, int age)
            : base(name, age) { }
    }
}