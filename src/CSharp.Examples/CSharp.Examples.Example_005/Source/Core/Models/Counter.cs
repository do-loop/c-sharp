namespace CSharp.Examples.Example_005.Source.Core.Models
{
    internal struct Counter
    {
        public int Value { get; private set; }

        public void Increase() => Value++;
    }
}