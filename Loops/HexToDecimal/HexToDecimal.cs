namespace HexToDecimal
{
    /*
        14. Hex to Decimal

        Description

        Using loops write a program that converts a hexadecimal integer number to its decimal form.

        The input is entered as string. The output should be a variable of type long.
        Do not use the built-in .NET functionality.
        Input

        The input will consists of a single line containing a single hexadecimal number as string.
        Output

        The output should consist of a single line - the decimal representation of the number as string.
        Constraints

        All numbers will be valid 64-bit integers.
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;
    using System.Text;

    public class HexToDecimal
    {
        public static void Main()
        {
            string hex = Console.ReadLine();

            long number = ConvertToDecimal(hex);

            Console.WriteLine(number);
        }

        private static long ConvertToDecimal(string hex)
        {
            long number = 0;

            for (int i = hex.Length - 1, p = 0; i >= 0; i--, p++)
            {
                switch (hex[i])
                {
                    case 'A': number += 10 * Raise(16, p); break;
                    case 'B': number += 11 * Raise(16, p); break;
                    case 'C': number += 12 * Raise(16, p); break;
                    case 'D': number += 13 * Raise(16, p); break;
                    case 'E': number += 14 * Raise(16, p); break;
                    case 'F': number += 15 * Raise(16, p); break;
                    default:
                        number += byte.Parse(hex[i].ToString()) * Raise(16, p);
                        break;
                }
            }

            return number;
        }

        public static long Raise(long number, int power)
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