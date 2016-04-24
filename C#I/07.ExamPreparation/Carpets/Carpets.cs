namespace Carpets
{
    // http://bgcoder.com/Contests/Practice/Index/41#3

    using System;
    using System.Text;

    public class Carpets
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());
            char dot = '.', backSlash = '\\', forwardSlash = '/', space = ' ';

            var carpet = new StringBuilder();
            var half = n / 2;

            for (int i = 1; i <= half; i++)
            {
                // top left quadrant
                carpet.Append(dot, half - i);
                for (int j = 0; j < i; j++)
                {
                    carpet.Append((j & 1) == 0 ? forwardSlash : space);
                }

                // top right quadrant
                for (int j = i - 1; j >= 0; j--)
                {
                    carpet.Append((j & 1) == 0 ? backSlash : space);
                }

                carpet.Append(dot, half - i);

                carpet.AppendLine();
            }

            for (int i = half; i >= 1; i--)
            {
                // bottom left quadrant
                carpet.Append(dot, half - i);
                for (int j = 0; j < i; j++)
                {
                    carpet.Append((j & 1) == 0 ? backSlash : space);
                }

                // bottom right quadrant
                for (int j = i - 1; j >= 0; j--)
                {
                    carpet.Append((j & 1) == 0 ? forwardSlash : space);
                }

                carpet.Append(dot, half - i);

                carpet.AppendLine();
            }

            Console.WriteLine(carpet);
        }
    }
}