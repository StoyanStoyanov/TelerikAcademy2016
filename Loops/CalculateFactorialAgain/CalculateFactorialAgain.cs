namespace CalculateFactorialAgain
{
    /*  06. Calculate! Again

        Description

        Write a program that calculates N! / K! for given N and K.

        Use only one loop.
        Input

        On the first line, there will be only one number - N
        On the second line, there will be only one number - K
        Output

        Output a single line, consisting of the result from the calculation described above.
        Constraints

        1 < K < N < 100
        Hint: overflow is possible
        N and K will always be valid integer numbers
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;
    using System.Numerics;

    public class CalculateFactorialAgain
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());
            var k = byte.Parse(Console.ReadLine());

            var nFactorial = new BigInteger(1);
            var kFactorial = new BigInteger(1);

            for (byte i = 1; i <= n; i++)
            {
                nFactorial *= i;
                if (i <= k)
                {
                    kFactorial *= i;
                }
            }

            Console.WriteLine(nFactorial / kFactorial);
        }
    }
}