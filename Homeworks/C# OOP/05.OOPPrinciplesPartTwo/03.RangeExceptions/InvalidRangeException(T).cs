namespace _03.RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : Exception
    {
        public InvalidRangeException(string message)
            : base(message)
        {
        }
    }
}
