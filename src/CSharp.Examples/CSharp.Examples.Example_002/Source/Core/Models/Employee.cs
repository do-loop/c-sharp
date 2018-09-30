namespace CSharp.Examples.Example_002.Source.Core.Models
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee() { }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}