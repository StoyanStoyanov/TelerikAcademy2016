namespace Ex01TRES4Numbers
{
    // http://bgcoder.com/Contests/Practice/Index/142#0
    // 100/100, 0.015 s

    using System;
    using System.Text;

    public class Ex01TRES4Numbers
    {
        public static void Main()
        {
            string[] numbersTRES4 = { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };

            var number = ulong.Parse(Console.ReadLine());

            var numberInTRES4 = DecimalToTargetBase(number, 9, numbersTRES4);

            Console.WriteLine(numberInTRES4);
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
    }
}