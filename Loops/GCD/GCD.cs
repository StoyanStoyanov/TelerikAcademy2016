namespace GCD
{
    /*
        15. GCD

        Description

        Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.

        Use the Euclidean algorithm (find it in Internet).
        Input

        On the first and only line of the input you will receive the 2 integers A and B, separated by a whitespace.
        Output

        Output a single number - the GCD of the numbers A and B.
        Constraints

        The numbers A and B will always be valid integers in the range [2, 500].
        Time limit: 0.1s
        Memory limit: 16MB

    */

    using System;

    public class GCD
    {
        public static void Main()
        {
            var ab = Console.ReadLine().Split(' ');
            var a = int.Parse(ab[0]);
            var b = int.Parse(ab[1]);

            while (a != 0 && b != 0)
            {
                a %= b;
                a ^= b;
                b ^= a;
                a ^= b;
            }

            // one of a and b is always a 0
            var gcd = a | b;

            // faster alternative to Math.Abs
            Console.WriteLine((gcd + (gcd >> 31)) ^ (gcd >> 31));      
        }
    }
}