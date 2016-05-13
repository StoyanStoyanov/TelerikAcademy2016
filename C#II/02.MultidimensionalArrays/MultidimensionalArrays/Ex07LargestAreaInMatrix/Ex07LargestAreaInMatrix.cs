namespace Ex07LargestAreaInMatrix
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/02.%20Multidimensional-Arrays/homework/07.%20Largest%20area%20in%20matrix
    // 100/100
    using System;

    public class Ex07LargestAreaInMatrix
    {
        public static void Main()
        {
            var nm = Console.ReadLine().Split(' ');
            var n = int.Parse(nm[0]);
            var m = int.Parse(nm[1]);
            var matrix = new int[n, m];
            for (int row = 0; row < n; row++)
            {
                var numStrings = Console.ReadLine().Split(' ');
                for (int col = 0; col < m; col++)
                    matrix[row, col] = int.Parse(numStrings[col]);
            }

            var bestCount = 0;
            var marked = new bool[n, m];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (!marked[row, col])
                    {
                        var count = DFS(matrix, marked, n, m, row, col);
                        if (bestCount < count) bestCount = count;
                    }
                }
            }

            Console.WriteLine(bestCount);
        }

        private static int DFS(int[,] matrix, bool[,] marked, int w, int h, int r, int c)
        {
            marked[r, c] = true;

            var equalElementsCount = 1;

            if (r + 1 < w && !marked[r + 1, c] && matrix[r + 1, c] == matrix[r, c])
                equalElementsCount += DFS(matrix, marked, w, h, r + 1, c);

            if (c + 1 < h && !marked[r, c + 1] && matrix[r, c + 1] == matrix[r, c])
                equalElementsCount += DFS(matrix, marked, w, h, r, c + 1);

            if (c - 1 >= 0 && !marked[r, c - 1] && matrix[r, c - 1] == matrix[r, c])
                equalElementsCount += DFS(matrix, marked, w, h, r, c - 1);

            if (r - 1 >= 0 && !marked[r - 1, c] && matrix[r - 1, c] == matrix[r, c])
                equalElementsCount += DFS(matrix, marked, w, h, r - 1, c);

            return equalElementsCount;
        }
    }
}