namespace SpiralMatrix
{
    /*
        17. Spiral Matrix

        Description

        Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) and 
        prints a matrix holding the numbers from 1 to N*N 
        in the form of square spiral like in the examples below.

        Input

        The input will always consist of a single line containing a single number - N.
        Output

        Output a spiral matrix as described below.
        Constraints

        N will always be a valid integer number.
        1 ≤ N ≤ 20
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;
    using System.Text;

    public class SpiralMatrix
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());

            var matrix = new int[n, n];

            var iterations = n * n;
            var direction = "right";

            for (int i = 0, row = 0, col = 0, num = 1; i < iterations; i++, num++)
            {
                if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    col--; // get back into the current square

                    direction = "down";
                    row++; // move into the new direction
                }
                else if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    row--; // get back into the current square

                    direction = "left";
                    col--; // move into the new direction
                }
                else if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    col++; // get back into the current square

                    direction = "up";
                    row--; // move into the new direction
                }
                else if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    row++; // get back into the current square

                    direction = "right";
                    col++; // move into the new direction
                }

                matrix[row, col] = num;

                switch (direction)
                {
                    case "right": col++; break;
                    case "down": row++; break;
                    case "left": col--; break;
                    case "up": row--; break;
                }
            }

            var output = new StringBuilder();
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    output.AppendFormat("{0}{1}", matrix[r, c], c == n - 1? "\n" : " ");
                } 
            }

            Console.WriteLine(output);
        }
    }
}