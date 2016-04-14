// 04. Write a program that gets two numbers from the console and prints the greater of them.
// On the only line print the larger of the two numbers
// * Try implementing it without using if-statements

using System;

public class NumberComparer
{
    public static void Main()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());

        var max = GetMax(a, b);
        Console.WriteLine(max);

        //var min = GetMin(a, b);
        //Console.WriteLine(min);
    }

    private static double GetMax(double a, double b)
    {
        return (a + b) / 2 + Math.Abs((a - b) / 2);
    }

    private static double GetMin(double a, double b)
    {
        return (a + b) / 2 - Math.Abs((a - b) / 2);
    }
}