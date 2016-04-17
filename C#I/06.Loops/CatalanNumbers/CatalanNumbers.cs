namespace CatalanNumbers
{
    /*
        08. Catalan Numbers

        Description

        In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula

        Write a program to calculate the Nth Catalan number by given N
        Input

        On the only line, you will receive the number N
        Output

        Output a single number - the Nth Catalan number
        Constraints

        N will always be a valid integer number in the range [0, 100]
        Hint: overflow is possible.
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;
    using System.Numerics;

    public class CatalanNumbers
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());

            var k = 2 * n;

            var nFactorial = new BigInteger(1);
            var kFactorial = new BigInteger(1);

            for (int i = 1; i <= k; i++)
            {
                kFactorial *= i;
                if (i <= n)
                {
                    nFactorial *= i;
                }
            }

            // (2n)! / ((n + 1)! * n!)
            Console.WriteLine(kFactorial / (nFactorial * (n + 1) * nFactorial));
        }
    }
}