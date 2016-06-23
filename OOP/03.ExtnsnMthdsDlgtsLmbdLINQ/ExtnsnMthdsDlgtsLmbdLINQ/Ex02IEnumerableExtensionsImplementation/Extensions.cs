namespace Ex02IEnumerableExtensionsImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> items)
            where T : struct
        {
            if (items.Count() == 0)
            {
                throw new ArgumentException();
            }

            if (items.Count() == 1)
            {
                return items.First();
            }

            dynamic sum = 0;

            foreach (var item in items)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> items)
            where T : struct
        {
            if (items.Count() == 0)
            {
                throw new ArgumentException();
            }

            if (items.Count() == 1)
            {
                return items.First();
            }

            dynamic product = 1;

            foreach (var item in items)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> items) 
            where T : IComparable<T>
        {
            if (items.Count() == 0)
            {
                throw new ArgumentException();
            }

            if (items.Count() == 1)
            {
                return items.First();
            }

            T min = items.First();

            foreach (var item in items.Skip(1))
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> items) 
            where T : IComparable<T>
        {
            if (items.Count() == 0)
            {
                throw new ArgumentException();
            }

            if (items.Count() == 1)
            {
                return items.First();
            }

            T max = items.First();

            foreach (var item in items.Skip(1))
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> items)
            where T : struct
        {
            if (items.Count() == 0)
            {
                throw new ArgumentException();
            }

            if (items.Count() == 1)
            {
                return items.First();
            }

            return (dynamic) items.Sum() / items.Count();
        }
    }
}