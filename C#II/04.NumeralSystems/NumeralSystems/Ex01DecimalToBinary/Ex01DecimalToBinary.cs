namespace Ex01DecimalToBinary
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/04.%20Numeral-Systems/homework/01.%20Decimal%20to%20binary

    using System;
    using System.Text;

    public class Ex01DecimalToBinary
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToBinary(n));
        }

        private static string DecimalToBinary(long n)
        {
            var binary = new StringBuilder();

            while (n > 0)
            {
                binary.Insert(0, n & 1);
                n >>= 1;
            }

            return binary.ToString();
        }
    }
}