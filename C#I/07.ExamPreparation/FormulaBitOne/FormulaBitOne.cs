namespace FormulaBitOne
{
    // http://bgcoder.com/Contests/Practice/Index/41#4
    // 100/100

    using System;

    public class FormulaBitOne
    {
        public static void Main()
        {
            var n = 8;
            var grid = new bool[n, n];

            for (int i = 0; i < n; i++)
            {
                var num = byte.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    grid[i, n - j - 1] = ((num >> j) & 1) != 0;
                }
            }

            var direction = "south";
            var previousDirection = "south";
            var reachedFinal = false;
            var trackLength = 0;
            var turnsCount = 0;
            var row = 0;
            var col = 7;

            while (true)
            {
                if (grid[row, col])
                {
                    break;
                }

                trackLength++;

                if (row == n - 1 && col == 0)
                {
                    reachedFinal = true;
                    break;
                }

                if (direction == "south" && ((row + 1 > n - 1) || grid[row + 1, col]))
                {
                    previousDirection = "south";
                    direction = "west";
                    turnsCount++;

                    if (col - 1 < 0 || grid[row, col - 1])
                    {
                        break;
                    }
                }
                else if (direction == "north" && (row - 1 < 0 || grid[row - 1, col]))
                {
                    previousDirection = "north";
                    direction = "west";
                    turnsCount++;

                    if (col - 1 < 0 || grid[row, col - 1])
                    {
                        break;
                    }
                }
                else if (direction == "west" && previousDirection == "south" 
                     && (col - 1 < 0 || grid[row, col - 1]))
                {
                    direction = "north";
                    turnsCount++;

                    if (row - 1 < 0 || grid[row - 1, col])
                    {
                        break;
                    }
                }
                else if (direction == "west" && previousDirection == "north" 
                     && (col - 1 < 0 || grid[row, col - 1]))
                {
                    direction = "south";
                    turnsCount++;

                    if (row + 1 > n - 1 || grid[row + 1, col])
                    {
                        break;
                    }
                }

                switch (direction)
                {
                    case "south": row++; break;
                    case "west": col--; break;
                    case "north": row--; break;
                }
            }

            if (reachedFinal)
            {
                Console.WriteLine("{0} {1}", trackLength, turnsCount);
            }
            else
            {
                Console.WriteLine("No {0}", trackLength);
            }
        }
    }
}