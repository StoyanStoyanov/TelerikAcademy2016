namespace Task04Cube
{
    // http://bgcoder.com/Contests/Practice/Index/202#3
    // 100/100

    using System;
    using System.Text;

    public class Task04Cube
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());

            var output = new StringBuilder();
            char space = ' ', colon = ':', x = 'X', slash = '/';
            var maxCols = 2 * n - 1;
            var innerMax = n - 2;

            var leftSide = n - 1;
            var middleSide = maxCols - 1;
            var rightSide = maxCols;
            var rows = innerMax;

            // top
            output.Append(space, n - 1);
            output.Append(colon, n);
            output.AppendLine();

            for (int row = 0; row < rows; row++)
            {
                for (int col = 1; col <= maxCols; col++)
                {
                    if (col < leftSide)
                    {
                        output.Append(space);
                    }
                    else if (col == leftSide)
                    {
                        output.Append(colon);
                    }
                    else if (col > leftSide && col < middleSide)
                    {
                        output.Append(slash);
                    }
                    else if (col == middleSide)
                    {
                        output.Append(colon);
                    }
                    else if (col > middleSide && col < rightSide)
                    {
                        output.Append(x);
                    }
                    else if (col == rightSide)
                    {
                        output.Append(colon);
                    }
                }

                output.AppendLine();
                leftSide--;
                middleSide--;
            }

            // middle
            output.Append(colon, n);
            output.Append(x, innerMax);
            output.Append(colon);
            output.AppendLine();

            for (int row = 0; row < rows; row++)
            {
                rightSide--;

                for (int col = 1; col <= maxCols; col++)
                {
                    if (col == leftSide || col == middleSide || col == rightSide)
                    {
                        output.Append(colon);
                    }
                    else if (col > leftSide && col < middleSide)
                    {
                        output.Append(space);
                    }
                    else if (col > middleSide && col < rightSide)
                    {
                        output.Append(x);
                    }
                }

                output.AppendLine();
            }

            // bottom
            output.Append(colon, n);
            output.Append(space, n - 1);

            Console.WriteLine(output);
        }
    }
}