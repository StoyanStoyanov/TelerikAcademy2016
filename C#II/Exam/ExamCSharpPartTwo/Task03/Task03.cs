namespace Task03
{
    using System;
    using System.Linq;
    using System.Text;

    public class Task03
    {
        public static void Main()
        {
            var baseColsCount = int.Parse(Console.ReadLine());
            var totalRowsCount = int.Parse(Console.ReadLine());

            var jagged = new int[totalRowsCount][];

            for (int row = 0; row < totalRowsCount + 2; row++)
            {
                jagged[row] = new int[(row < totalRowsCount / 2 ? (row + 1) * baseColsCount : (totalRowsCount - row) * baseColsCount) + 2];

                for (int col = 0, step = row + 1; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = -1;
                }
            }

            //for (int row = 0; row < totalRowsCount; row++)
            //{
            //    jagged[row] = new int[row < totalRowsCount / 2 ? (row + 1) * baseColsCount : (totalRowsCount - row) * baseColsCount];

            //    for (int col = 0, value = row + 1, step = row + 1; col < jagged[row].Length; col++, value += step)
            //    {
            //        jagged[row][col] = value;
            //    }
            //}

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write("{0, 4}", jagged[i][j]);
                }

                Console.WriteLine();
            }

            var popcurineCoords = Console.ReadLine().Split();
            var popR = int.Parse(popcurineCoords[0]);
            var popC = int.Parse(popcurineCoords[1]);

            var rabbitCoords = Console.ReadLine().Split();
            var rabbitR = int.Parse(popcurineCoords[0]);
            var rabbitC = int.Parse(popcurineCoords[1]);


        }

        static void PrintMatrix(int[,] matrix)
        {
            var output = new StringBuilder();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    output.Append(matrix[row, col]);
                }

                output.AppendLine();
            }

            Console.WriteLine(output);
        }
    }
}