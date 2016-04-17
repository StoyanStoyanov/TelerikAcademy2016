namespace DecimalToHex
{
    /*
        13. Decimal to Hex
        Description

        Using loops write a program that converts an integer number to its hexadecimal representation.

        The input is entered as long. The output should be a variable of type string.
        Do not use the built-in .NET functionality.
        Input

        On the first and only line you will receive an integer in the decimal numeral system.
        Output

        On the only output line write the hexadecimal representation of the read number.
        Constraints

        All numbers will always be valid 64-bit integers.
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;
    using System.Text;

    public class DecimalToHex
    {
        static void Main()
        {
            var n = long.Parse(Console.ReadLine());

            var hex = ConvertToHex(n);

            Console.WriteLine(hex);
        }

        private static string ConvertToHex(long number)
        {
            var hex = new StringBuilder();

            while (number != 0)
            {
                var remainder = number % 16;
                switch (remainder)
                {
                    case 10: hex.Append("A"); break;
                    case 11: hex.Append("B"); break;
                    case 12: hex.Append("C"); break;
                    case 13: hex.Append("D"); break;
                    case 14: hex.Append("E"); break;
                    case 15: hex.Append("F"); break;
                    default: hex.Append(remainder); break;
                }

                number /= 16;
            }

            return Reverse(hex.ToString());
        }

        public static string Reverse(string s)
        {
            var reversed = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversed.Append(s[i]);
            }

            return reversed.ToString();
        }
    }
}