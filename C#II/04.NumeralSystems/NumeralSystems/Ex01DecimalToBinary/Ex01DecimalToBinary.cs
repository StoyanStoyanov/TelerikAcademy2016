namespace Ex01DecimalToBinary
{
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