namespace Ex11ThirdBit
{
    /* 
        11. Using bitwise operators, write a program that uses an expression to find the value 
        of the bit at index 3 of an unsigned integer read from the console.
        The bits are counted from right to left, starting from bit 0.
        The result of the expression should be either 1 or 0. Print it on the console.
    */

    using System;

    public class ThirdBit
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var position = 3;

            var mask = 1 << position;
            var result = (number & mask) >> position;

            Console.WriteLine(result);
        }
    }
}