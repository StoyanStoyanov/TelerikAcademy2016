namespace Ex03CustomException
{
    using System;

    public class Range<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public Range(T start, T end)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; private set; }

        public T End { get; private set; }

        public bool IsInRange(T value)
        {
            return (dynamic)this.Start <= value && (dynamic)this.End >= value;   
        }

        public override string ToString()
        {
            return string.Format("[{0} ... {1}]", this.Start, this.End);
        }
    }
}