namespace Ex03LoverOfThree
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Ex03LoverOfThree
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split(' ');
            var rows = int.Parse(dimensions[0]);
            var cols = int.Parse(dimensions[1]);
            var field = new int[rows, cols];
            var visited = new bool[rows, cols];

            for (int row = rows - 1; row >= 0; row--)
            {
                for (int col = 0, num = (rows - row - 1) * 3; col < cols; col++, num += 3)
                {
                    field[row, col] = num;
                }
            }

            PrintMatrix(field);

            var n = int.Parse(Console.ReadLine());
            var directions = new string[n];
            var moves = new int[n];

            var movesByDirection = new Dictionary<string, Action>();
  
            for (int i = 0; i < n; i++)
            {
                var pair = Console.ReadLine().Split(' ');
                directions[i] = pair[0];
                moves[i] = int.Parse(pair[1]);
            }

            var sRow = rows - 1;
            var sCol = 0;
            long sum = 0;

            for (int i = 0; i < directions.Length; i++)
            {
                switch (directions[i])
                {
                    case "RU":
                    case "UR":
                        for (int j = 0; j < moves[i]; j++)
                        {
                            GoUpRight(ref sRow, ref sCol, 0, cols - 1);
                            if (!visited[sRow, sCol])
                            {
                                sum += field[sRow, sCol];
                                visited[sRow, sCol] = true;
                            }
                        }
                        break;
                    case "LU":
                    case "UL":
                        for (int j = 0; j < moves[i]; j++)
                        {
                            GoUpLeft(ref sRow, ref sCol, 0, 0);
                            if (!visited[sRow, sCol])
                            {
                                sum += field[sRow, sCol];
                                visited[sRow, sCol] = true;
                            }
                        }
                        break;
                    case "DL":
                    case "LD":
                        for (int j = 0; j < moves[i]; j++)
                        {
                            GoDownLeft(ref sRow, ref sCol, rows - 1, 0);
                            if (!visited[sRow, sCol])
                            {
                                sum += field[sRow, sCol];
                                visited[sRow, sCol] = true;
                            }
                        }
                        break;
                    case "RD":
                    case "DR":
                        for (int j = 0; j < moves[i]; j++)
                        {
                            GoDownRight(ref sRow, ref sCol, rows - 1, cols - 1);
                            if (!visited[sRow, sCol])
                            {
                                sum += field[sRow, sCol];
                                visited[sRow, sCol] = true;
                            }
                        }
                        break;
                }
            }

            Console.WriteLine(sum);
        }

        private static void GoUpRight(ref int row, ref int col, int minRow, int maxCol)
        {
            if (row > minRow && col < maxCol)
            {
                row--;
                col++;
            }
        }

        private static void GoDownRight(ref int row, ref int col, int maxRow, int maxCol)
        {
            if (row < maxRow && col < maxCol)
            {
                row++;
                col++;
            }
        }

        private static void GoDownLeft(ref int row, ref int col, int maxRow, int minCol)
        {
            if (row < maxRow && col > minCol)
            {
                row++;
                col--;
            }
        }

        private static void GoUpLeft(ref int row, ref int col, int minRow, int minCol)
        {
            if (row > minRow && col > minCol)
            {
                row--;
                col--;
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            var output = new StringBuilder();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    output.AppendFormat("{0, 3}", matrix[row, col]);
                }

                output.AppendLine();
            }

            Console.WriteLine(output);
        }
    }
}