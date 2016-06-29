namespace Ex03CustomException
{
    using System;
    using System.Runtime.Serialization;

    public class InvalidRangeException<T> : ApplicationException
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public Range<T> Range { get; private set; }

        public InvalidRangeException(string message, Range<T> range) : this(message, range, null) { }

        public InvalidRangeException(string message, Range<T> range, Exception innerException) : base(message, innerException)
        {
            this.Range = range;            
        }

        protected InvalidRangeException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}