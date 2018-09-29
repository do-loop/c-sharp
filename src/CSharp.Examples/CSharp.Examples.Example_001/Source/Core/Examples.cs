using System;

namespace CSharp.Examples.Example_001.Source.Core
{
    internal class Examples
    {
        public Examples Example_001()
        {
            var a = ("cat", "dog");

            // cat & dog
            Console.WriteLine($"{a.Item1} & {a.Item2}");
            // ValueTuple`2
            Console.WriteLine(a.GetType().Name);

            var b = ("cat", "dog", "duck");

            // cat & dog & duck
            Console.WriteLine($"{b.Item1} & {b.Item2} & {b.Item3}");
            // ValueTuple`3
            Console.WriteLine(b.GetType().Name);

            var c = (Cat: "cat", Dog: "dog");

            // cat & dog
            Console.WriteLine($"{c.Cat} & {c.Dog}");
            // ValueTuple`2
            Console.WriteLine(c.GetType().Name);

            var (cat, dog) = ("cat", "dog");

            // cat & dog
            Console.WriteLine($"{cat} & {dog}");

            return this;
        }

        public Examples Example_002()
        {
            const string a = "cat";
            const int b = 99;

            var c = (a, b);

            // cat & 99
            Console.WriteLine($"{c.a} & {c.b}");
            // ValueTuple`2
            Console.WriteLine(c.GetType().Name);

            const string d = "cat";
            var e = (42, d);

            // 42 & cat
            Console.WriteLine($"{e.Item1} & {e.d}");
            // ValueTuple`2
            Console.WriteLine(e.GetType().Name);

            return this;
        }

        public Examples Example_003()
        {
            var a = ("cat", 99);
            var b = new ValueTuple<string, int>("cat", 99);

            // True
            Console.WriteLine(a == b);

            return this;
        }

        public Examples Example_004()
        {
            var a = ("cat", 1, 2, 3, 4, 5, 6, 7, 8, 9, "dog");

            // ValueTuple`8
            Console.WriteLine(a.GetType().Name);
            // ValueTuple`4
            Console.WriteLine(a.Rest.GetType().Name);

            var b = new ValueTuple<string, int, int, int, int, int, int, (int, int, int, string)>(
                "cat", 1, 2, 3, 4, 5, 6, (7, 8, 9, "dog")
            );

            // ValueTuple`8
            Console.WriteLine(b.GetType().Name);
            // ValueTuple`4
            Console.WriteLine(b.Rest.GetType().Name);

            // True
            Console.WriteLine(a == b);
            // True
            Console.WriteLine(a.Rest == b.Rest);

            return this;
        }

        public Examples Example_005()
        {
            var a = ("cat", 1, 2, 3, 4, 5, 6, 7, 8, 9, "dog");

            // ValueTuple`8
            Console.WriteLine(a.GetType().Name);
            // ValueTuple`4
            Console.WriteLine(a.Rest.GetType().Name);

            var b = new Tuple<string, int, int, int, int, int, int, Tuple<int, int, int, string>>(
                "cat", 1, 2, 3, 4, 5, 6, new Tuple<int, int, int, string>(7, 8, 9, "dog")
            );

            // Tuple`8
            Console.WriteLine(b.GetType().Name);
            // Tuple`4
            Console.WriteLine(b.Rest.GetType().Name);

            var c = b.ToValueTuple();

            // True
            Console.WriteLine(a == c);
            // True
            Console.WriteLine(a.Rest == c.Rest);

            return this;
        }
    }
}