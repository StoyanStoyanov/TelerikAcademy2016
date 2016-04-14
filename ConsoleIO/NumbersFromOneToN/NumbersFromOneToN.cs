/*
    08. Write a program that reads an integer number N from the console and prints all the numbers in the interval [1, n], each on a single line.

    Input

    On the only line you will receive the number N
    Output

    You should print the numbers from 1 to N, each on a separate line
    Constraints

    1 <= N < 1000
    N will always be a valid integer number
    Time limit: 0.1s
    Memory limit: 16MB
*/

using System;
using System.Text;

public class NumbersFromOneToN
{
    public static void Main()
    {
        var n = ushort.Parse(Console.ReadLine());

        var output = new StringBuilder();
        for (int i = 1; i <= n; i++)
        {
            output.AppendLine(i.ToString());
        }

        Console.Write(output);
    }
}