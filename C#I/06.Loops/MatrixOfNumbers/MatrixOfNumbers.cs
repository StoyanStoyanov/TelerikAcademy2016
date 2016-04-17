namespace MatrixOfNumbers
{
    /*
        09. Matrix of Numbers

        Description

        Write a program that reads from the console a positive integer number N 
        and prints a matrix like in the examples below. 
        Use two nested loops.

        Challenge: achieve the same effect without nested loops
        Input

        The input will always consist of a single line, which contains the number N
        Output

        See the examples.
        Constraints

        1 <= N <= 20
        N will always be a valid integer number
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;
    using System.Text;

    public class MatrixOfNumbers
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());
            var output = new StringBuilder();
            var separator = " ";

            //for (int i = 1, s = 1, numOfSymbols = n * n; i <= numOfSymbols; i++, s++)
            //{
            //    if (i % n == 0)
            //    {
            //        output.AppendLine(s.ToString());
            //        s = s - n + 1;
            //    }
            //    else
            //    {
            //        output.Append(s);
            //        output.Append(separator);
            //    }
            //}

            for (int j = 1; j <= n; j++)
            {
                for (int f = j; f < n + j; f++)
                {
                    output.Append(f);
                    output.Append(separator);
                }

                output.AppendLine();
            }

            Console.WriteLine(output);
        }
    }
}