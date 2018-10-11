using System;

namespace CSharp.Examples.Example_004.Source.Core
{
    internal class Examples
    {
        public Examples Example_001()
        {
            // Результат: 0 (ближайшее четное число).
            Console.WriteLine(Math.Round(-0.5));
            
            // Результат: -2 (ближайшее четное число).
            Console.WriteLine(Math.Round(-1.5));

            // Эквивалент. Результат: 0.
            Console.WriteLine(Math.Round(-0.5, MidpointRounding.ToEven));
            
            // Эквивалент. Результат: -2.
            Console.WriteLine(Math.Round(-1.5, MidpointRounding.ToEven));

            // Результат: -1.
            Console.WriteLine(Math.Round(-0.5, MidpointRounding.AwayFromZero));
            
            // Результат: -2.
            Console.WriteLine(Math.Round(-1.5, MidpointRounding.AwayFromZero));

            return this;
        }

        public Examples Example_002()
        {
            const int a = 100;

            // True
            Console.WriteLine(a == a << 32);
            // True
            Console.WriteLine(a == a << 64);

            const long b = 1000;

            // False
            Console.WriteLine(b == b << 32);
            // True
            Console.WriteLine(b == b << 64);
            // True
            Console.WriteLine(b == b << 128);

            return this;
        }
    }
}