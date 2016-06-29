namespace Ex03CustomException
{
    /* 
     * Exercise 03. 
     * 
     * Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
     * It should hold error message and a range definition [start … end].
     * 
     * Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> 
     * by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
     * 
     */

    using System;

    public class CustomException
    {
        public static void Main()
        {
            // Create a new range of type int
            var numbersRange = new Range<int>(1, 100);

            // Create a new range of type DateTime
            var datesRange = new Range<DateTime>(new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));

            // Print the numbers range on the console
            Console.WriteLine("Numbers range: {0}", numbersRange);

            // Print the dates range on the console
            Console.WriteLine("Dates range: {0}", datesRange);

            Console.WriteLine();

            try
            {
                // Check if -1 is within the valid range of values
                CheckRange(-1, numbersRange);
            }
            catch (InvalidRangeException<int> exc)
            {
                Console.WriteLine("{0} {1}", exc.Message, exc.Range);
            }

            try
            {
                // Check if a given date is within the valid range of values
                CheckRange(new DateTime(1979, 1, 1), datesRange);
            }
            catch (InvalidRangeException<DateTime> exc)
            {
                Console.WriteLine("{0} {1}", exc.Message, exc.Range);
            }
        }

        public static void CheckRange<T>(T value, Range<T> range)
            where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            if (range.IsInRange((dynamic)value))
            {
                Console.WriteLine("Congratulations! Value is within the valid range.");
            }
            else
            {
                throw new InvalidRangeException<T>(string.Format("{0} {1} is NOT within the valid range!", value.GetType().Name, value), range);
            }
        }
    }
}