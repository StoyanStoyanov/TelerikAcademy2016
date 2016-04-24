namespace FormulaBitOne
{
    using System;

    public class FormulaBitOne
    {
        public static void Main()
        {
            byte n = 8;

            var grid = new byte[n, n];

            for (byte row = 0; row < n; row++)
            {
                var bits = Convert.ToString(byte.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
                for (int col = 0; col < n; col++)
                {
                    grid[row, col] = byte.Parse(bits[col].ToString());
                }
            }

            var direction = "south";
            var carRow = 0;
            var carCol = 7;
            var turnsCount = 0;

            while (true)
            {
                if (direction == "south" && (carRow > n - 1 || grid[carRow, carCol] == 1))
                {
                    carRow--;

                    direction = "west";
                    turnsCount++;
                    carCol--;
                }
                else if (direction == "west" && (carCol < 0 || grid[carRow, carCol] == 1))
                {
                    carCol++;

                    direction = "north";
                    turnsCount++;
                    carRow--;
                }
                else if (direction == "north" && (carRow < 0 || grid[carRow, carCol] == 1))
                {
                    carRow++;

                    direction = "west";
                    turnsCount++;
                    carCol--;
                }

                switch (direction)
                {
                    case "south": carRow++; break;
                    case "west": carCol--; break;
                    case "north": carRow--; break;
                }
            }

           // PrintMatrix(grid);
        }

        static void PrintMatrix(byte[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}