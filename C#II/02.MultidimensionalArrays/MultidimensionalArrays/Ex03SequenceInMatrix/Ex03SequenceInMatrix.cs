namespace Ex03SequenceInMatrix
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/02.%20Multidimensional-Arrays/homework/03.%20Sequence%20in%20matrix
    // 80/100
    using System;

    public class Ex03SequenceInMatrix
    {
        public static void Main()
        {
            var nm = Console.ReadLine().Split(' ');
            var n = int.Parse(nm[0]);
            var m = int.Parse(nm[1]);
            var matrix = new string[n, m];

            for (int row = 0; row < n; row++)
            {
                var strings = Console.ReadLine().Split(' ');
                for (int col = 0; col < m; col++)
                    matrix[row, col] = strings[col];
            }

            var maxLength = 1;

            for (int row = n - 1; row >= 0; row--)
            {
                for (int col = m - 1; col >= 0; col--)
                {
                    int bestRowLength = GetBestRowLength(row, col, matrix);
                    if (maxLength < bestRowLength)
                        maxLength = bestRowLength;

                    int bestColLength = GetBestColLength(row, col, matrix);
                    if (maxLength < bestColLength)
                        maxLength = bestColLength;

                    int bestDiagLength = GetBestDiagLength(row, col, matrix);
                    if (maxLength < bestDiagLength)
                        maxLength = bestDiagLength;
                }
            }

            Console.WriteLine(maxLength);
        }

        private static int GetBestDiagLength(int row, int col, string[,] matrix)
        {
            var result = 1;
            var start = matrix[row, col];

            while (row > 0 && col > 0)
            {
                if (matrix[--row, --col] != start)
                    break;

                result++;
            }

            return result;
        }

        private static int GetBestColLength(int row, int col, string[,] matrix)
        {
            var result = 1;
            var start = matrix[row, col];

            while (row > 0)
            {
                if (matrix[--row, col] != start)
                    break;

                result++;
            }

            return result;
        }

        private static int GetBestRowLength(int row, int col, string[,] matrix)
        {
            var result = 1;
            var start = matrix[row, col];

            while (col > 0)
            {
                if (matrix[row, --col] != start)
                    break;

                result++;
            }

            return result;
        }
    }
}