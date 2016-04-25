namespace Sheets
{
    // http://bgcoder.com/Contests/Practice/Index/41#2
    // 100/100

    using System;
    using System.Text;

    public class Sheets
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var maxSize = 1024; // A0
            var index = 0;
            var unusedSheets = new StringBuilder();

            while (maxSize > 0)
            {
                if (n < maxSize)
                {
                    unusedSheets.AppendFormat("{0}{1}\n", "A", index);
                }
                else
                {
                    n -= maxSize;
                }

                maxSize >>= 1;
                index++;
            }

            Console.Write(unusedSheets);
        }
    }
}