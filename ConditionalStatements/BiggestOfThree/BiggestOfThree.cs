namespace BiggestOfThree
{
    /*
        Description

        Write a program that finds the biggest of three numbers that are read from the console.

        Input

        On the first three lines you will receive the three numbers, each on a separate line.
        Output

        On the only output line, write the biggest of the three numbers.
        Constraints

        The three numbers will always be valid floating-point numbers in the range [-200, 200].
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;

    public class BiggestOfThree
    {
        public static void Main()
        {
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());
            var c = decimal.Parse(Console.ReadLine());

            var greaterAB = a > b ? a : b;
            var greatestABC = greaterAB > c ? greaterAB : c;

            Console.WriteLine(greatestABC);
        }
    }
}