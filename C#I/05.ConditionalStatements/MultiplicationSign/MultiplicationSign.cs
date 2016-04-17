namespace MultiplicationSign
{
    /*
        Description

        Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.

        Use a sequence of if operators.
        Input

        On the first three lines, you will receive the three numbers, each on a separate line
        Output

        Output a single line - the sign of the product of the three numbers
        Constraints

        The input will always consist of valid floating-point numbers
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;

    public class MultiplicationSign
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var numberOfNegatives = GetNegativeNumbersCount(a, b, c);
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine(0);
            }
            else if ((numberOfNegatives & 1) == 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }

        private static int GetNegativeNumbersCount(params double[] numbers)
        {
            var minusCount = 0;

            for (int i = 0, numberOfNumbers = numbers.Length; i < numberOfNumbers; i++)
            {
                var currentNum = numbers[i];
                if (currentNum < 0)
                {
                    minusCount++;
                }
            }

            return minusCount;
        }
    }
}