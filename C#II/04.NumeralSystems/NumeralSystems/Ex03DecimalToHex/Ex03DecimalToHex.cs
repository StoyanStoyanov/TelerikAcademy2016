namespace Ex03DecimalToHex
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/04.%20Numeral-Systems/homework/03.%20Decimal%20to%20hexadecimal

    using System;
    using System.Text;

    public class Ex03DecimalToHex
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());

            Console.WriteLine(DecimalToHex(n));
        }

        private static string DecimalToHex(long number)
        {
            var hex = new StringBuilder();
            var map = "0123456789ABCDEF";

            while (number > 0)
            {
                var hexDigit = map[(int)(number % 16)];
                hex.Insert(0, hexDigit);
                number >>= 4;
            }

            return hex.ToString();
        }
    }
}