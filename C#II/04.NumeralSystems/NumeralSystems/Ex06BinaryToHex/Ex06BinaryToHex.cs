namespace Ex06BinaryToHex
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/04.%20Numeral-Systems/homework/06.%20Binary%20to%20hexadecimal

    using System;
    using System.Text;

    public class Ex06BinaryToHex
    {
        public static void Main()
        {
            var binary = Console.ReadLine();

            var hex = BinaryToHex(binary);

            Console.WriteLine(hex);
        }

        private static string BinaryToHex(string binary)
        {
            // add some leading zeroes if needed
            while (binary.Length % 4 != 0)
            {
                binary = binary.PadLeft(binary.Length + 1, '0');
            }

            var hex = new StringBuilder();
            var currentByteHalf = new StringBuilder();

            for (int i = 0; i < binary.Length; i++)
            {
                currentByteHalf.Append(binary[i]);

                if (currentByteHalf.Length == 4)
                {
                    switch (currentByteHalf.ToString())
                    {
                        case "0000": hex.Append("0"); break;
                        case "0001": hex.Append("1"); break;
                        case "0010": hex.Append("2"); break;
                        case "0011": hex.Append("3"); break;
                        case "0100": hex.Append("4"); break;
                        case "0101": hex.Append("5"); break;
                        case "0110": hex.Append("6"); break;
                        case "0111": hex.Append("7"); break;
                        case "1000": hex.Append("8"); break;
                        case "1001": hex.Append("9"); break;
                        case "1010": hex.Append("A"); break;
                        case "1011": hex.Append("B"); break;
                        case "1100": hex.Append("C"); break;
                        case "1101": hex.Append("D"); break;
                        case "1110": hex.Append("E"); break;
                        case "1111": hex.Append("F"); break;
                    }

                    currentByteHalf.Clear();
                }
            }

            return hex.ToString();
        }
    }
}