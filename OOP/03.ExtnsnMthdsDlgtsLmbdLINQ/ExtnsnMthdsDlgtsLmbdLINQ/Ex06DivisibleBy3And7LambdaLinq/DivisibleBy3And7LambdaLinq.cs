namespace Ex06DivisibleBy3And7LambdaLinq
{
    /* 06. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
     * Use the built-in extension methods and lambda expressions. 
     * Rewrite the same with LINQ.
     */

    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class DivisibleBy3And7LambdaLinq
    {
        public static void Main()
        {
            int[] numbers = new int[101];

            // Filling (quite faster) the array with the numbers from 0 to 100 inclusive
            Parallel.For(0, numbers.Length, i => numbers[i] = i);

            // Using Lambda expression
            foreach (var num in numbers.Where(n => n % 21 == 0))
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            // Using Linq query operators
            foreach (var num in from n in numbers where n % 21 == 0 select n)
            {
                Console.WriteLine(num);
            }
        }
    }
}
