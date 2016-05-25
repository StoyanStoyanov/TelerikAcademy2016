namespace Ex01CalculationProblem
{
    using System;
    using System.Text;

    public class Ex01CalculationProblem
    {
        public static void Main()
        {
            var letterNums = Console.ReadLine().Split();

            var sysChars = "abcdefghijklmnopqrstuvw";
            var sysBase = 23;
            var sum = 0;

            for (int i = 0; i < letterNums.Length; i++)
            {
                sum += ToDecimal(letterNums[i], sysBase, sysChars);
            }

            Console.WriteLine("{0} = {1}", DecimalToTargetBase(sum, 23, sysChars), sum);
        }

        private static int ToDecimal(string sourceNum, int sourceBase, string baseChars)
        {   
            var map = baseChars.ToCharArray();
            var num = 0;

            for (int i = 0; i < sourceNum.Length; i++)
            {
                var digit = Array.BinarySearch(map, sourceNum[i]);
                num = digit + num * sourceBase;
            }

            return num;
        }

        private static string DecimalToTargetBase(int d, int targetBase, string baseChars)
        {
            var map = baseChars;
            var num = new StringBuilder();

            while (d > 0)
            {
                num.Insert(0, map[d % targetBase]);
                d /= targetBase;
            }

            return num.ToString();
        }
    }
}