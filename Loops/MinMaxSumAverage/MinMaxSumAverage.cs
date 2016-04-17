namespace MinMaxSumAverage
{
    /*  03. MMSA(Min, Max, Sum, Average) of N Numbers

        Description

        Write a program that reads from the console a sequence of N integer numbers and returns 
        the minimal, the maximal number, the sum and the average of all numbers 
        (displayed with 2 digits after the decimal point).

        The input starts by the number N (alone in a line) followed by N lines, each holding an integer number.
        The output is like in the examples below.

        Input

        On the first line, you will receive the number N.
        On each of the next N lines, you will receive a single floating-point number.
        Output

        You output must always consist of exactly 4 lines - the minimal element on the first line, the maximal on the second, 
        the sum on the third and the average on the fourth, in the following format:
        min=3
        max=6
        sum=9
        avg=4.5
        Constraints

        1 <= N <= 1000
        All numbers will be valid floating-point numbers that will be in the range [-10000, 10000]
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;

    public class MinMaxSumAverage
    {
        public static void Main()
        {
            var n = ushort.Parse(Console.ReadLine());

            decimal max = -10000, min = 10000, sum = 0;
  
            for (int i = 0; i < n; i++)
            {
                var num = decimal.Parse(Console.ReadLine());

                // get min
                if (min > num)
                {
                    min = num;
                }

                // get max
                if (max < num)
                {
                    max = num;
                }

                // get sum
                sum += num;
            }

            Console.WriteLine("min={0:F2}\nmax={1:F2}\nsum={2:F2}\navg={3:F2}", min, max, sum, sum / n);
        }
    }
}