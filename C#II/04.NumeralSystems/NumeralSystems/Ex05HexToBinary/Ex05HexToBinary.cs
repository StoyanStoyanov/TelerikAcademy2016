namespace Ex05HexToBinary
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/04.%20Numeral-Systems/homework/05.%20Hexadecimal%20to%20binary

    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Ex05HexToBinary
    {
        static Dictionary<char, string> hexBinMap = new Dictionary<char, string>()
        {
            {'0', "0000" },
            {'1', "0001" },
            {'2', "0010" },
            {'3', "0011" },
            {'4', "0100" },
            {'5', "0101" },
            {'6', "0110" },
            {'7', "0111" },
            {'8', "1000" },
            {'9', "1001" },
            {'A', "1010" },
            {'B', "1011" },
            {'C', "1100" },
            {'D', "1101" },
            {'E', "1110" },
            {'F', "1111" },
        };

        public static void Main()
        {
            var hex = Console.ReadLine();

            Console.WriteLine(HexToBinary(hex));
        }

        private static string HexToBinary(string hex)
        {
            var binary = new StringBuilder();

            for (int i = 0; i < hex.Length; i++)
            {
                binary.Append(hexBinMap[hex[i]]);
            }

            // remove leading zeroes
            var j = -1;
            while (binary[++j] == '0')
            {
                binary.Remove(j--, 1);
            }

            return binary.ToString();
        }
    }
}