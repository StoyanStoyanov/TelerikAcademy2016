/*
    07. Write a program that reads 5 integer numbers from the console and prints their sum.

    Input

    You will receive 5 numbers on five separate lines.

    Output

    Your output should consist only of a single line - the sum of the 5 numbers.

    Constraints

    All 5 numbers will always be valid integer numbers between -1000 and 1000, inclusive
    Time limit: 0.1s
    Memory limit: 16MB
*/

using System;

public class SumOfFiveNumbers
{
    public static void Main()
    {
        byte n = 5;
        short sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += short.Parse(Console.ReadLine());
        }

        Console.WriteLine(sum);
    }
}