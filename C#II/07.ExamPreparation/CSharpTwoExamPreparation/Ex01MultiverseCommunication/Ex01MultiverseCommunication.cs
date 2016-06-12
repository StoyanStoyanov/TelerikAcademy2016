namespace Ex01MultiverseCommunication
{
    // http://bgcoder.com/Contests/Practice/Index/94#0
    // 100/100

    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Ex01MultiverseCommunication
    {
        public static void Main()
        {
            Dictionary<string, int> multiverse = new Dictionary<string, int>()
            {
                { "CHU", 0 }, 
                { "TEL", 1 },
                { "OFT", 2 },
                { "IVA", 3 },
                { "EMY", 4 },
                { "VNB", 5 },
                { "POQ", 6 },
                { "ERI", 7 },
                { "CAD", 8 },
                { "K-A", 9 },
                { "IIA", 10 },
                { "YLO", 11 },
                { "PLA", 12 }
            };

            var input = Console.ReadLine();

            var numInDecimal = ToDecimal(input, 13, multiverse);

            Console.WriteLine(numInDecimal);
        }

        private static string DecimalToTargetBase(ulong d, ulong targetBase, string[] baseChars)
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

        private static long ToDecimal(string sourceNum, int sourceBase, Dictionary<string, int> baseChars)
        {
            var map = baseChars;
            var num = 0L;
            var current = new StringBuilder();

            for (int i = 0; i < sourceNum.Length; i++)
            {
                current.Append(sourceNum[i]);
                if (current.Length == 3)
                {
                    var key = current.ToString();
                    var digit = map[key];

                    num = digit + num * sourceBase;
                    current.Clear();
                }
            }

            return num;
        }
    }
}