namespace Ex03CompareCharArrays
{
    /*
        03. Compare char arrays

        Write a program that compares two char arrays lexicographically (letter by letter).

        Input:

        On the first line you will receive the first char array as a string
        On the second line you will receive the second char array as a string

        Output:

        Print < if the first array is lexicographically smaller
        Print > if the second array is lexicographically smaller
        Print = if the arrays are equal

        Constraints:

        1 <= size of arrays <= 128
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;

    public class Ex03CompareCharArrays
    {
        public static void Main()
        {
            var firstString = Console.ReadLine();
            var secondString = Console.ReadLine();

            var firstStringLen = firstString.Length;
            var secondStringLen = secondString.Length;
            var length = firstStringLen > secondStringLen ? secondStringLen : firstStringLen;

            for (int i = 0; i < length; i++)
            {
                if (firstString[i] > secondString[i])
                {
                    Console.WriteLine(">");
                    return;
                }
                else if (firstString[i] < secondString[i])
                {
                    Console.WriteLine("<");
                    return;
                }
            }

            if (firstStringLen > secondStringLen)
            {
                Console.WriteLine(">");
            }
            else if (firstStringLen < secondStringLen)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}