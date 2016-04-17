namespace CalculateFactorialOnceAgain
{
    /*
        07. Calculate 3!

        Description

        In combinatorics, the number of ways to choose N different members out of a group of N different elements 
        (also known as the number of combinations) is calculated by the following formula: N! / (K! * (N - K)!)
        For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
        Your task is to write a program that calculates N! / (K! * (N - K)!) for given N and K.

        Try to use only two loops.
        Input

        On the first line, there will be only one number - N
        On the second line, there will also be only one number - K
        Output

        On the only output line, write the result of the calculation for the provided N and K
        Constraints

        1 < K < N < 100
        Hint: overflow is possible
        Time limit: 0.1s
        Memory limit: 16MB

    */


    using System;
    using System.Numerics;

    public class CalculateFactorialOnceAgain
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());
            var k = byte.Parse(Console.ReadLine());

            var nFactorial = new BigInteger(1);
            var kFactorial = new BigInteger(1);
            var nKFactorial = new BigInteger(1);

            for (byte i = 1; i <= n; i++)
            {
                nFactorial *= i;
                if (i <= k)
                {
                    kFactorial *= i;
                }
                else if (i > k)
                {
                    nKFactorial *= (i - k);
                }
            }

            // N! / (K! * (N - K)!)
            Console.WriteLine(nFactorial / (kFactorial * nKFactorial));
        }
    }
}