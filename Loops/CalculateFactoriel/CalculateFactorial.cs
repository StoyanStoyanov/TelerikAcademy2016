namespace CalculateFactoriel
{
    /*
        05. Calculate!

        Description

        Write a program that, for a given two integer numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.

        Use only one loop. Print the result with 5 digits after the decimal point.
        Input

        On the first line you will receive one number - N.
        On the second line you will receive another number - x.
        Output

        Output only one number - the sum of the sequence for the given N and x.
        Constraints

        N will always be a valid integer between 2 and 20, inclusive.
        X will always be a valid floating-point number between 0 and 100
        X * N will always be less than 50
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;

    public class CalculateFactorial
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());

            int currentF = 1; // should be int... doesn't work with long wtf!?
            double sum = 1 + 1 / x;

            for (int i = 2; i <= n; i++)
            {
                currentF *= i;
                sum += (currentF / Math.Pow(x, i));
            }

            Console.WriteLine("{0:F5}", sum);
        }
    }
}