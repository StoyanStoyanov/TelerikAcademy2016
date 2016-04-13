namespace Ex12NthBit
{
    /*
        Description

        Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit.

        Input

        On the first line you will receive the number P. On the second line you will receive the number N.
        Output

        Output a single value - the value of the N-th bit in P.
        Constraints

        N will be a positive integer and always smaller than 55.
        0 <= P <= 255
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;

    public class NthBit
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var n = byte.Parse(Console.ReadLine());

            Console.WriteLine((number & 1 << n) >> n);
        }
    }
}