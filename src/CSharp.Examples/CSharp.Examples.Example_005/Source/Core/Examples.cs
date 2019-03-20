using System;
using System.Collections.Generic;
using CSharp.Examples.Example_005.Source.Core.Models;

namespace CSharp.Examples.Example_005.Source.Core
{
    internal class Examples
    {
        public Examples Example_001()
        {
            var a = new[] { new Counter() };

            a[0].Increase();

            // 1
            // Значение элемента массива возвращается по ссылке.
            Console.WriteLine(a[0].Value);

            var b = new List<Counter> { new Counter() };

            b[0].Increase();

            // 0
            // Значение элемента списка возвращается по значению.
            Console.WriteLine(b[0].Value);

            return this;
        }
    }
}
