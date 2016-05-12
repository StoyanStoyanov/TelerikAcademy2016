namespace Task04
{
    using System;
    using System.Text;

    public class Task04
    {
        public static void Main()
        {
            var s = int.Parse(Console.ReadLine());
            var sign = char.Parse(Console.ReadLine());
            var output = new StringBuilder();
            var space = ' ';

            var width = s * 3;
            var left = 0;
            var right = width;

            for (int row = 0; row < s / 2 + s / 2 + s / 2 - 1 + 1; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (col >= left && col < s || col < right && col >= 2 * s)
                    {
                        output.Append(sign);
                    }
                    else if (row == s / 2 - 1 && (col == s + s / 2 - 1 || col == s + s / 2 + 1))
                    {
                        output.Append(sign);
                    }
                    else if (row >= s / 2 && col > left && col < right)
                    {
                        output.Append(sign);
                    }
                    else
                    {
                       output.Append(space);
                    }
                }

                // trim spaces right
                var len = output.Length;
                var i = len;
                while (output[--i] == space)
                {
                    output.Length--;
                }

                output.AppendLine();
                if (row < s / 2)
                {
                    left++;
                    right--;
                }

                if (row == s / 2 + s / 2 - 2)
                {
                    left = s;
                    right = 2 * s - 1;
                }

                if (row > s / 2 + s / 2 - 2)
                {
                    left++;
                    right--;
                }
            }

            Console.Write(output);
        }
    }
}