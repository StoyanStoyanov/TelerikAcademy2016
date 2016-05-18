namespace Ex07OneSystemToAnyOther
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/04.%20Numeral-Systems/homework/07.%20One%20system%20to%20any%20other

    using System;
    using System.Text;

    public class Ex07OneSystemToAnyOther
    {
        public static void Main()
        {
            var s = int.Parse(Console.ReadLine());
            var n = Console.ReadLine();
            var d = int.Parse(Console.ReadLine());

            Console.WriteLine(DecimalToTargetBase(ToDecimal(s, n), d));
        }

        // 2 <= s, d <= 16
        private static long ToDecimal(int sourceBase, string sourceNum)
        {
            var map = "0123456789ABCDEF".ToCharArray();
            var num = 0L;

            for (int i = 0; i < sourceNum.Length; i++)
            {
                var digit = Array.BinarySearch(map, sourceNum[i]);
                num = digit + num * sourceBase;
            }

            return num;
        }

        // 2 <= s, d <= 16
        private static string DecimalToTargetBase(long decValue, int targetBase)
        {
            var map = "0123456789ABCDEF";
            var num = new StringBuilder();

            while (decValue > 0)
            {
                num.Insert(0, map[(int)(decValue % targetBase)]);
                decValue /= targetBase;
            }

            return num.ToString();
        }
    }
}