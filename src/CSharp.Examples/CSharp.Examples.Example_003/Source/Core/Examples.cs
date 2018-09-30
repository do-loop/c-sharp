using System;

namespace CSharp.Examples.Example_003.Source.Core
{
    using Models;

    internal class Examples
    {
        public Examples Example_001()
        { 
            var a = new Employee("name", 21, DateTime.Now);
            var b = new Employee("name", 22, DateTime.Now.AddDays(10));

            // True (first non-null field is name)
            Console.WriteLine(a.GetHashCode() == b.GetHashCode());

            var c = new Employee("name", 21, DateTime.Now);
            var d = new Employee("new_name", 21, DateTime.Now);

            // False (first non-null field is name, but they are different)
            Console.WriteLine(c.GetHashCode() == d.GetHashCode());

            var e = new Employee(null, 21, DateTime.Now);
            var g = new Employee(null, 21, DateTime.Now.AddDays(10));

            // True (first non-null field is age)
            Console.WriteLine(e.GetHashCode() == g.GetHashCode());

            return this;
        }
    }
}