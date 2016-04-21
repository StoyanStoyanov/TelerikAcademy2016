namespace Task03Cube3D
{
    using System;
    using System.Text;

    public class Task03Cube3D
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());

            var cube = new StringBuilder();
            var left = 0;
            var right = n;
            var middle = n - 1;
            var cols = 2 * n - 1;
            var rows = n - 2; // half the rows

            // top
            cube.Append(':', n);
            cube.Append(' ', n - 1);
            cube.AppendLine();

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (col == left || col == middle || col == right)
                    {
                        cube.Append(':');
                    }
                    else if (col > left && col < middle)
                    {
                        cube.Append(' ');
                    }
                    else if (col > middle && col < right)
                    {
                        cube.Append('|');
                    }
                }

                cube.AppendLine();
                right++;
            }

            // middle
            cube.Append(':', n);
            cube.Append('|', n - 2);
            cube.Append(':');
            cube.AppendLine();

            for (int row = 0; row < rows; row++)
            {
                left++;
                middle++;

                for (int col = 0; col < cols; col++)
                {
                    if (col < left)
                    {
                        cube.Append(' ');
                    }
                    else if (col == left || col == middle || col == right)
                    {
                        cube.Append(':');
                    }
                    else if (col > left && col < middle)
                    {
                        cube.Append('-');
                    }
                    else if (col > middle && col < right)
                    {
                        cube.Append('|');
                    }
                }

                cube.AppendLine();
            }

            // bottom
            cube.Append(' ', n - 1);
            cube.Append(':', n);
            cube.AppendLine();

            Console.WriteLine(cube);
        }
    }
}