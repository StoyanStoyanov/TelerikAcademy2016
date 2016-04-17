// 01. Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class SumOfNumbers
{
    static void Main()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());

        var sum = a + b + c;

        Console.WriteLine(sum);
    }
}