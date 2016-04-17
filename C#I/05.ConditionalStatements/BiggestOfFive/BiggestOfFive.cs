namespace BiggestOfFive
{
    /*  06.

        Description

        Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.

        Input

        On the first 5 lines you will receive the 5 numbers, each on a separate line
        Output

        On the only output line, write the biggest of the 5 numbers
        Constraints

        The 5 numbers will always be valid floating-point numbers in the range [-200, 200]
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;

    public class BiggestOfFive
    {
        public static void Main()
        {
            var max = decimal.Parse(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                var currentNum = decimal.Parse(Console.ReadLine());
                if (max < currentNum)
                {
                    max = currentNum;
                }
            }

            Console.WriteLine(max);
        }
    }
}