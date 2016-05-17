namespace Ex02BinaryToDecimal
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/04.%20Numeral-Systems/homework/02.%20Binary%20to%20decimal

    using System;

    public class Ex02BinaryToDecimal
    {
        public static void Main()
        {
            var binary = Console.ReadLine();

            //long number = ConvertToBase10(binary, 2);
            long number = BinaryToDecimal(binary);

            Console.WriteLine(number);
        }

        private static long ConvertToBase10(string source, int bass)
        {
            long numberInBase10 = 0;

            for (int i = source.Length - 1, p = 0; i >= 0; i--, p++)
            {
                numberInBase10 += (source[i] - '0') * Pow(bass, p);
            }

            return numberInBase10;
        }

        private static long Pow(long num, long pow)
        {
            long powered = 1;

            for (long i = pow; i > 0; i--)
            {
                powered *= num;
            }

            return powered;
        }

        private static long BinaryToDecimal(string binary)
        {
            var dec = 0L;

            for (int i = 0; i < binary.Length; i++)
            {
                dec = (binary[i] - '0') + (dec << 1);
            }

            return dec;
        }
    }
}