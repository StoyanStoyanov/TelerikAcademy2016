namespace Ex05Doge
{
    // http://bgcoder.com/Contests/Practice/Index/142#4
    // 100/100, 0.09 s

    using System;
    using System.Numerics;

    public class Ex05Doge
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var n = int.Parse(input[0]);
            var m = int.Parse(input[1]);

            input = Console.ReadLine().Split();
            var foodX = int.Parse(input[0]);
            var foodY = int.Parse(input[1]);

            // no need to look at the cells
            // right and down from the food
            var matrix = new bool[foodX + 1, foodY + 1];
            var k = int.Parse(Console.ReadLine());
            for (int i = k - 1; i >= 0; i--)
            {
                input = Console.ReadLine().Split();
                var enemyX = int.Parse(input[0]);
                var enemyY = int.Parse(input[1]);

                // as we can only move right and down
                // ignore enemies which are right
                // and down from the food
                if (enemyX <= foodX && enemyY <= foodY)
                {
                    matrix[enemyX, enemyY] = true;
                }
            }

            // the number of ways can sometimes be a big number
            // 2 ^ 500 (151 digit number)
            var dp = new BigInteger[foodX + 1, foodY + 1];
            dp[0, 0] = 1;

            // populate the ways for the cells in the first row
            for (int col = 1, row = 0; col < dp.GetLength(1); col++)
            {
                var ways = matrix[row, col] ? 0 : dp[row, col - 1];
                dp[row, col] = ways;
            }

            // populate the ways for the cells in the first col
            for (int row = 1, col = 0; row < dp.GetLength(0); row++)
            {
                var ways = matrix[row, col] ? 0 : dp[row - 1, col];
                dp[row, col] = ways;
            }

            // populate the rest based on the 1st row & col
            for (int row = 1; row < dp.GetLength(0); row++)
            {
                for (int col = 1; col < dp.GetLength(1); col++)
                {
                    var enemy = matrix[row, col];
                    var waysTop = dp[row - 1, col];
                    var waysLeft = dp[row, col - 1];
                    var ways = enemy ? 0 : waysTop + waysLeft;
                    dp[row, col] = ways;
                }
            }

            // number of all possible ways 
            // for the Doge to go from his 
            // start location to the food
            var numberOfWays = dp[foodX, foodY];

            Console.WriteLine(numberOfWays);
        }
    }
}