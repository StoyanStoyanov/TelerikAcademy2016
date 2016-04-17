namespace Ex08SquareRoot
{
    // 08. Write a program that calculates the square root of the number 12345 and prints it on the console.

    using System;

    public class SquareRoot
    {
        public static void Main()
        {
            var number = 12345d;

            var squareRoot = Math.Sqrt(number);

            Console.WriteLine(squareRoot);
        }
    }
}
