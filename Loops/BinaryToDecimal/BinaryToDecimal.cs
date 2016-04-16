namespace BinaryToDecimal
{
    /*
        11. Binary to Decimal

        Description

        Using loops write a program that converts a binary integer number to its decimal form.

        The input is entered as string. The output should be a variable of type long.
        Do not use the built-in .NET functionality.
        Input

        You will receive exactly one line containing an integer number representation in binary
        Output

        On the only output line write the decimal representation of the number
        Constraints

        All input numbers will be valid 32-bit integers
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;

    public class BinaryToDecimal
    {
        public static void Main()
        {
            string binary = Console.ReadLine();
            Console.WriteLine(ConvertToDecimal(binary, 2));
        }

        private static long ConvertToDecimal(string representation, int sourceBase)
        {
            long numberInDec = 0;

            for (int i = 0, repLen = representation.Length; i < repLen; i++)
            {
                var currentBit = representation[repLen - i - 1];
                if (currentBit == '1')
                {
                    numberInDec += Raise(sourceBase, i);
                }
            }

            return numberInDec;
        }

        private static long Raise(int number, int power)
        {
            long raised = 1;

            for (int i = 0; i < power; i++)
            {
                raised *= number;
            }

            return raised;
        }
    }
}