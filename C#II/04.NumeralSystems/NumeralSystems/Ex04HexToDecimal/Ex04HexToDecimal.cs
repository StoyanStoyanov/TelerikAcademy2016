namespace Ex04HexToDecimal
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/04.%20Numeral-Systems/homework/04.%20Hexadecimal%20to%20decimal

    using System;

    public class Ex04HexToDecimal
    {
        public static void Main()
        {
            var hex = Console.ReadLine();

            var dec = HexToDecimal(hex);

            Console.WriteLine(dec);
        }

        private static long HexToDecimal(string hex)
        {
            var map = "0123456789ABCDEF".ToCharArray();
            var num = 0L;

            for (int i = 0; i < hex.Length; i++)
            {
                var digit = Array.BinarySearch(map, hex[i]);
                num = digit + (num << 4);
            }

            return num;
        }
    }
}