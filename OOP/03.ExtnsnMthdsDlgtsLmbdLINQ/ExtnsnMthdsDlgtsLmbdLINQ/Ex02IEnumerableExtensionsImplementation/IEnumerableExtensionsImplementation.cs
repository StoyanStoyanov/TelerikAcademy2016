namespace Ex02IEnumerableExtensionsImplementation
{
    /* 02. Implement a set of extension methods for IEnumerable<T> that implement
     * the following group functions: sum, product, min, max, average.
     */

    using System;

    public class IEnumerableExtensionsImplementation
    {
        public static void Main()
        {
            int[] items = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Sum: {0}", items.Sum());
            Console.WriteLine("Product: {0}", items.Product());
            Console.WriteLine("Max: {0}", items.Max());
            Console.WriteLine("Min: {0}", items.Min());
            Console.WriteLine("Average: {0}", items.Average());
        }
    }
}