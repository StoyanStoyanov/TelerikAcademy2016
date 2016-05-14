namespace Ex01OddOrEven
{
    // 01. Write a program that reads an integer from the console, uses an expression to check if given integer
    // is odd or even, and prints "even NUMBER" or "odd NUMBER", where you should print the input number's value 
    // instead of NUMBER.

    using System;

    public class OddOrEven
    {
        public static void Main()
        {
            var number = sbyte.Parse(Console.ReadLine());
            var firstBit = number & 1;

            Console.WriteLine("{0} {1}", firstBit == 1 ? "odd" : "even", number);
        }
    }
}
