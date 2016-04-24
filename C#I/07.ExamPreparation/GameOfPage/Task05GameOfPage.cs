namespace GameOfPage
{
    // http://bgcoder.com/Contests/Practice/Index/107#4
    // 100/100

    using System;

    public class Task05GameOfPage
    {
        public static void Main()
        {
            var tray = new int[18, 18];

            for (int row = 0; row < 16; row++)
            {
                var currenLine = Console.ReadLine();
                for (int col = 0; col < 16; col++)
                {
                    tray[row + 1, col + 1] = currenLine[col] - '0';
                }
            }

            var cookies = 0;
            var cookiePrice = 1.79M;

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "paypal")
                {
                    break;
                }

                var row = int.Parse(Console.ReadLine()) + 1;
                var col = int.Parse(Console.ReadLine()) + 1;
                var answer = CheckLocation(row, col, tray);
                if (command == "what is")
                {
                    Console.WriteLine(answer);
                }
                else if (command == "buy")
                {
                    switch (answer)
                    {
                        case "smile":
                            Console.WriteLine("smile");
                            break;
                        case "broken cookie":
                        case "cookie crumb":
                            Console.WriteLine("page");
                            break;
                        case "cookie":
                            TakeCookie(row, col, tray);
                            cookies++;
                            break;
                    }
                }
            }

            Console.WriteLine("{0:F2}", cookies * cookiePrice);
        }

        private static void TakeCookie(int row, int col, int[,] tray)
        {
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                     tray[i, j] = 0;
                }
            }
        }

        private static string CheckLocation(int row, int col, int[,] tray)
        {
            if (tray[row, col] == 0)
            {
                return "smile";
            }

            if (tray[row, col] == 1
             && tray[row - 1, col - 1] == 1
             && tray[row - 1, col] == 1
             && tray[row - 1, col + 1] == 1
             && tray[row, col - 1] == 1
             && tray[row, col + 1] == 1
             && tray[row + 1, col - 1] == 1
             && tray[row + 1, col] == 1
             && tray[row + 1, col + 1] == 1)
            {
                return "cookie";
            }

            if (tray[row, col] == 1
             && tray[row - 1, col - 1] == 0
             && tray[row - 1, col] == 0
             && tray[row - 1, col + 1] == 0
             && tray[row, col - 1] == 0
             && tray[row, col + 1] == 0
             && tray[row + 1, col - 1] ==0
             && tray[row + 1, col] == 0
             && tray[row + 1, col + 1] == 0)
            {
                return "cookie crumb";
            }

            return "broken cookie";
        }
    }
}