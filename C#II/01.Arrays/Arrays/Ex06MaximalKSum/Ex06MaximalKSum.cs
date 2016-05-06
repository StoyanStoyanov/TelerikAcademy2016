namespace Ex06MaximalKSum
{
    /*
        06. Maximal K sum

        Description:

        Write a program that reads two integer numbers N and K and an array of N elements from the console.
        Find the maximal sum of K elements in the array.

        Input:

        On the first line you will receive the number N
        On the second line you will receive the number K
        On the next N lines the numbers of the array will be given

        Output:

        Print the maximal sum of K elements in the array

        Constraints:

        1 <= N <= 1024
        1 <= K <= N
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;
    using System.Collections.Generic;

    public class Ex06MaximalKSum
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            var elements = new List<long>(n);
            for (int i = n - 1; i >= 0; i--)
            {
                elements.Add(long.Parse(Console.ReadLine()));
            }

            long maxSum = 0;

            for (int i = k - 1; i >= 0; i--)
            {
                var maxElement = long.MinValue;
                for (int j = elements.Count - 1; j >= 0; j--)
                {
                    var currentElement = elements[j];
                    if (maxElement < currentElement)
                    {
                        maxElement = currentElement;
                    }
                }

                maxSum += maxElement;
                elements.Remove(maxElement);
            }

            Console.WriteLine(maxSum);
        }
    }
}