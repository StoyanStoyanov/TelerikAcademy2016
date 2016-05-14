namespace Ex02MaximalSum
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/02.%20Multidimensional-Arrays/homework/02.%20Maximal%20sum
    // 100/100
    using System;

    public class Ex02MaximalSum
    {
        public static void Main()
        {
            var nm = Console.ReadLine().Split(' ');
            var n = int.Parse(nm[0]);
            var m = int.Parse(nm[1]);
            var matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                var numberStrings = Console.ReadLine().Split(' ');
                for (int col = 0; col < m; col++)
                    matrix[row, col] = int.Parse(numberStrings[col]);
            }

            var bestSquareSum = int.MinValue;

            for (int row = 1; row < n - 1; row++)
            {
                for (int col = 1; col < m - 1; col++)
                {
                    var currentSquareSum = 0;

                    for (int sRow = row - 1; sRow <= row + 1; sRow++)
                        for (int sCol = col - 1; sCol <= col + 1; sCol++)
                            currentSquareSum += matrix[sRow, sCol];

                    if (currentSquareSum > bestSquareSum)
                        bestSquareSum = currentSquareSum;
                }
            }

            Console.WriteLine(bestSquareSum);
        }
    }
}