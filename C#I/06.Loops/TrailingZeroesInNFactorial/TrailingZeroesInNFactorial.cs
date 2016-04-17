namespace TrailingZeroesInNFactorial
{
    /*
        16. Trailing 0 in N!

        Description

        Write a program that calculates with how many zeroes the factorial of a given number N has at its end.

        Your program should work well for very big numbers, e.g. N = 100000.
        Input

        On the only input line, you will receive a single integer - the number N
        Output

        Output a single number - the count of trailing zeroes for the N!
        Constraints

        N will always be a valid positive integer number.
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;

    public class TrailingZeroesInNFactorial
    {
        public static void Main()
        {
            // https://en.wikipedia.org/wiki/Trailing_zero
            var n = int.Parse(Console.ReadLine());
            var factor = 5;
            var p = 1;
            var numOfZeroes = 0;

            while (true)
            {
                var currentProduct = Pow(factor, p);
                if (currentProduct > n)
                {
                    break;
                }

                numOfZeroes += n / currentProduct;
                p++;
            }

            Console.WriteLine(numOfZeroes);
        }

        private static int Pow(int num, int p)
        {
            var powered = 1;

            for (int i = 0; i < p; i++)
            {
                powered *= num;
            }

            return powered;
        }
    }
}