namespace Ex03LoverOfThree
{
    using System;

    public class Ex03LoverOfThree
    {
        public static void Main()
        {
            var dims = Console.ReadLine().Split(' ');
            var rows = int.Parse(dims[0]);
            var cols = int.Parse(dims[1]);

            var field = new int[rows + 2, cols + 2];
            // set field with - 1, including border
            for (int r = 0; r < rows + 2; r++)
            {
                for (int c = 0; c < cols + 2; c++)
                {
                    field[r, c] = -1;
                }
            }
            // set field with values, exc border
            for (int r = rows - 1; r >= 0; r--)
            {
                var value = (rows - r - 1) * 3;
                for (int c = 0; c < cols; c++, value += 3)
                {
                    field[r + 1, c + 1] = value;
                }
            }

            var visited = new bool[rows + 2, cols + 2];
            var n = int.Parse(Console.ReadLine());
            string[] dm;
            string direction;
            int moves, pRow, pCol, row = rows, col = 1, sum = 0;
            // no need to visit start cell, as its value is 0
            for (int i = 0; i < n; i++)
            {
                dm = Console.ReadLine().Split();
                direction = dm[0];
                moves = int.Parse(dm[1]);
                for (int m = 0; m < moves - 1; m++)
                {
                    pRow = row;
                    pCol = col;

                    switch (direction)
                    {
                        case "RU":
                        case "UR":
                            row--;
                            col++;
                            break;
                        case "LU":
                        case "UL":
                            row--;
                            col--;
                            break;
                        case "DL":
                        case "LD":
                            row++;
                            col--;
                            break;
                        case "RD":
                        case "DR":
                            row++;
                            col++;
                            break;
                    }

                    if (field[row, col] == -1)
                    {
                        row = pRow;
                        col = pCol;
                        break;
                    }

                    if (!visited[row, col])
                    {
                        visited[row, col] = true;
                        sum += field[row, col];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}