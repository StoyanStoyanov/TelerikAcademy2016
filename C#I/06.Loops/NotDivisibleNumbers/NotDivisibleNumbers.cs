﻿namespace NotDivisibleNumbers
{
    /*
        02. Not Divisible Numbers

        Description

        Write a program that reads from the console a positive integer N and prints all the numbers from 1 to N not divisible by 3 or 7, on a single line, separated by a space.

        Input

        Will always consists of one valid integer number - the number N.
        Output

        Should always consists of the numbers from 1 to N, which are not divisible by 3 or 7, separated by a whitespace.
        Constraints

        1 < N < 1500
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;
    using System.Text;

    public class NotDivisibleNumbers
    {
        public static void Main()
        {
            var n = ushort.Parse(Console.ReadLine());

            var output = new StringBuilder();
            var separator = " ";

            for (int num = 1; num <= n; num++)
            {
                if (num % 3 != 0 && num % 7 != 0)
                {
                    output.Append(num);
                    output.Append(separator);
                }
            }

            output.Length--;

            Console.WriteLine(output);
        }
    }
}