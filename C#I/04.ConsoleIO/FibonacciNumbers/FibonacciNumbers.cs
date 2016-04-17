/*
    Description

    Write a program that reads a number N and prints on the console the first N members of the Fibonacci sequence 
    (at a single line, separated by comma and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

    Input

    On the only line you will receive the number N
    Output

    On the only line you should print the first N numbers of the sequence, separated by ", " (comma and space)
    Constraints

    1 <= N <= 50
    N will always be a valid positive integer number
    Time limit: 0.1s
    Memory limit: 16MB

*/

using System;
using System.Text;

public class FibonacciNumbers
{
    public static void Main()
    {
        var n = byte.Parse(Console.ReadLine());
        var output = new StringBuilder();

        ulong previous = 0, next = 1;
        var separator = ", ";
 
        output.Append(previous);
        output.Append(separator);
        output.Append(next);

        for (int i = 2; i < n; i++)
        {
            var temp = next;
            next += previous;
            previous = temp;

            output.Append(separator);
            output.Append(next);
        }

        Console.WriteLine(output);
    }
}