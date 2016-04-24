namespace KaspichaniaBoats
{
    // http://bgcoder.com/Contests/Practice/Index/107#3
    // 100/100

    using System;
    using System.Text;

    public class KaspichaniaBoats
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());
            var width = 2 * n + 1;
            var height = 6 + ((n - 3) / 2) * 3;

            var left = n;
            var midbeam = n;
            var right = n;
            var dot = '.';
            var asterix = '*';

            var output = new StringBuilder();

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (row == n || (row == height - 1 && col > left && col < right) 
                     || col == left || col == midbeam || col == right)
                    {
                        output.Append(asterix);
                    }
                    else
                    {
                        output.Append(dot);
                    }
                }

                output.AppendLine();

                if (row < n)
                {
                    left--;
                    right++;
                }
                else
                {
                    left++;
                    right--;
                }
            }

            Console.WriteLine(output);
        }
    }
}