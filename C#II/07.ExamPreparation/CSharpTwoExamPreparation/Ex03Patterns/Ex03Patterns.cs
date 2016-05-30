namespace Ex03Patterns
{
    // http://bgcoder.com/Contests/Practice/Index/142#2
    // 92/100

    using System;

    public class Ex03Patterns
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var matrix = new long[n, n];
            string[] line;

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine().Split();
                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i, j] = long.Parse(line[j]);
                }
            }

            long bestSum = long.MinValue, sum;

            var found = false;

            for (int row = 0; row + 2 < n; row++)
            {
                for (int col = 0; col + 4 < n; col++)
                {
                    if (matrix[row, col] + 1 == matrix[row, col + 1]
                        && matrix[row, col] + 2 == matrix[row, col + 2]
                        && matrix[row, col] + 3 == matrix[row + 1, col + 2]
                        && matrix[row, col] + 4 == matrix[row + 2, col + 2]
                        && matrix[row, col] + 5 == matrix[row + 2, col + 3]
                        && matrix[row, col] + 6 == matrix[row + 2, col + 4]
                        )
                    {
                        if (!found)
                        {
                            found = true;
                        }

                        sum = 7 * matrix[row, col] + 21;
                        if (bestSum < sum)
                        {
                            bestSum = sum;
                        }
                    }
                }
            }

            if (found)
            {
                Console.WriteLine("YES {0}", bestSum);
            }
            else
            {
                long sumOfDiag = 0;

                for (int row = 0, col = 0; row < n; row++, col++)
                {
                    sumOfDiag += matrix[row, col];
                }

                Console.WriteLine("NO {0}", sumOfDiag);
            }
        }
    }
}