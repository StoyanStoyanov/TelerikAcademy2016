namespace SortThreeNumbers
{
    /*
        Description

        Write a program that enters 3 real numbers and prints them sorted in descending order.

        Use nested if statements.
        Don’t use arrays and the built-in sorting functionality.
        Input

        On the first three lines, you will receive the three numbers, each on a separate line.
        Output

        Output a single line on the console - the sorted numbers, separated by a whitespace
        Constraints

        The three numbers will always be valid integer numbers in the range [-1000, 1000]
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;

    public class SortThreeNumbers
    {
        public static void Main()
        {
            var a = short.Parse(Console.ReadLine());
            var b = short.Parse(Console.ReadLine());
            var c = short.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
            }
            else if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
        }
    }
}