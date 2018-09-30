using System;

namespace CSharp.Examples.Example_002.Source.Core
{
    using Models;

    internal class Examples
    {
        public Examples Example_001()
        {
            // Инициализаторы.

            var a = new Employee("name", 21);

            // name
            Console.WriteLine(a.Name);

            var b = new Employee { Name = "name", Age = 21 };

            // 21
            Console.WriteLine(b.Age);

            return this;
        }

        public Examples Example_002()
        {
            // ?? (оператор объединения с null)

            Employee GetEmployee() => new Employee("name", 21);

            var a = GetEmployee() ?? new Employee("another_name", 21);

            // name
            Console.WriteLine(a.Name);

            Employee GetNullEmployee() => null;

            var b = GetNullEmployee() ?? new Employee("another_name", 21);

            // another_name
            Console.WriteLine(b.Name);

            var c = GetNullEmployee() ?? GetNullEmployee() ?? new Employee("another_name", 21);

            // another_name
            Console.WriteLine(c.Name);

            return this;
        }

        public Examples Example_003()
        {
            // Интерполированные строки.

            var employee = new Employee("name", 21);

            var a = string.Format("Name: {0}, Age: {1}.", employee.Name, employee.Age);

            // Name: name, Age: 21.
            Console.WriteLine(a);

            var b = $"Name: {employee.Name}, Age: {employee.Age}.";

            // Name: name, Age: 21.
            Console.WriteLine(b);

            return this;
        }

        public Examples Example_004()
        {
            // .? (элвис оператор, оператор безопасной навигации)

            Employee GetNullEmployee() => null;

            var employee = GetNullEmployee();

            // null ?? "error" => error
            Console.WriteLine(employee?.Name ?? "error");
            
            // Null Reference Exception (NRE)
            // Console.WriteLine(employee.Name);

            return this;
        }

        public Examples Example_005()
        {
            // nameof(...)

            // Example_005
            Console.WriteLine(nameof(Example_005));
            // Employee
            Console.WriteLine(nameof(Employee));
            // Name
            Console.WriteLine(nameof(Employee.Name));
            // ToString
            Console.WriteLine(nameof(Employee.Age.ToString));

            return this;
        }

        public Examples Example_006()
        {
            // is, as

            Employee GetEmployee() => new Employee("name", 21);
            SpecificEmployee GetSpecificEmployee() => new SpecificEmployee("name", 21);

            var employee = GetEmployee();
            var specific = GetSpecificEmployee();

            // False (не может быть приведен к типу)
            Console.WriteLine(employee is SpecificEmployee);
            // True (может быть приведен к типу)
            Console.WriteLine(specific is Employee);

            // null
            var b = employee as SpecificEmployee;

            // null ?? "False" => False
            Console.WriteLine(b?.GetType().Name ?? "False");

            // Исключение.
            // var c = (SpecificEmployee) employee;

            // Исключения не будет (может быть приведен к типу).
            var c = (Employee) specific;

            // Specific
            Console.WriteLine(c?.GetType().Name);

            return this;
        }
    }
}