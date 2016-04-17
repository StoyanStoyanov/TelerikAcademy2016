namespace DecimalToBinary
{
    /*  12. Decimal to Binary

        Description

        Using loops write a program that converts an integer number to its binary representation.

        The input is entered as long. The output should be a variable of type string.
        Do not use the built-in .NET functionality.
        Input

        On the only input line you will receive the decimal integer number.
        Output

        Output a single string - the representation of the input decimal number in it's binary representation.
        Constraints

        All numbers will always be valid 32-bit integers.
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;

    public class DecimalToBinary
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());

            string binary = ConvertToBinary(n);

            Console.WriteLine(binary);
        }

        public static string ConvertToBinary(long number)
        {
            var binary = string.Empty;

            while (number > 0)
            {
                // get the current first bit left to right
                binary = (number & 1) + binary;

                // cut the current first bit left to right
                number >>= 1;
            }

            return binary.ToString();
        }
    }
}