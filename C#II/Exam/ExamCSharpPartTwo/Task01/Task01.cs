namespace Task01
{
    using System;
    using System.Text;
    using System.Numerics;

    public class Task01
    {
        public static void Main()
        {
            var numberInBase26 = Console.ReadLine();
            var operation = Console.ReadLine();
            var numberInBase7 = Console.ReadLine();

            var num26InDecimal = ToDecimal(numberInBase26, 26, "abcdefghijklmnopqrstuvwxyz");
            var num7InDecimal = ToDecimal(numberInBase7, 7, "0123456");

            BigInteger resultInDecimal = 0;

            if (operation == "+")
            {
                resultInDecimal = num26InDecimal + num7InDecimal;
            }
            else if (operation == "-")
            {
                resultInDecimal = num26InDecimal - num7InDecimal;
            }

            var resultInBase9 = DecimalToTargetBase(resultInDecimal, 9, "012345678");

            Console.WriteLine(resultInBase9);
        }

        private static string DecimalToTargetBase(BigInteger d, BigInteger targetBase, string baseChars)
        {
            var map = baseChars;
            var num = new StringBuilder();

            do // cover case when input number is 0
            {
                num.Insert(0, map[(int)(d % targetBase)]);
                d /= targetBase;
            }
            while (d > 0);

            return num.ToString();
        }

        private static BigInteger ToDecimal(string sourceNum, int sourceBase, string baseChars)
        {
            var map = baseChars.ToCharArray();
            BigInteger num = 0;

            for (int i = 0; i < sourceNum.Length; i++)
            {
                var digit = Array.BinarySearch(map, sourceNum[i]);
                num = digit + num * sourceBase;
            }

            return num;
        }
    }
}