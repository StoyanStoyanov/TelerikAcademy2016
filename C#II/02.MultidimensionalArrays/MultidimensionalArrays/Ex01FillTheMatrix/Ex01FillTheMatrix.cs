namespace Ex01FillTheMatrix
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/02.%20Multidimensional-Arrays/homework/01.%20Fill%20the%20matrix
    // 100/100
    using System;
    using System.Text;

    public class Ex01FillTheMatrix
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());
            var type = (char)Console.Read();
            var matrix = new int[n, n];

            switch (type)
            {
                case 'a': FillMatrixA(matrix, n); break;
                case 'b': FillMatrixB(matrix, n); break;
                case 'c': FillMatrixC(matrix, n); break;
                case 'd': FillMatrixD(matrix, n); break;
            }

            Print(matrix, n, type == 'd');
        }

        private static void FillMatrixD(int[,] matrix, int size)
        {
            var iterations = size * size;
            var direction = "right";

            for (int i = 0, row = 0, col = 0, num = 1; i < iterations; i++, num++)
            {
                if (direction == "right" && (col > size - 1 || matrix[row, col] != 0))
                {
                    col--; // get back into the current square

                    direction = "down";
                    row++; // move into the new direction
                }
                else if (direction == "down" && (row > size - 1 || matrix[row, col] != 0))
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
        }

        private static void FillMatrixC(int[,] matrix, int size)
        {
            var num = 1;
            var currentRow = size - 1;
            var currentCol = 0;
            var startRow = currentRow;
            var startCol = currentCol;
            var iterations = size * size;

            while (num <= iterations)
            {
                while (currentCol < size && currentRow < size)
                    matrix[currentRow++, currentCol++] = num++;

                if (startRow == 0) startCol++;
                else startRow--;

                currentCol = startCol;
                currentRow = startRow;
            }
        }

        private static void FillMatrixB(int[,] matrix, int size)
        {
            for (int row = 0, num = 0; row < size; row++)
                for (int col = 0; col < size; col++)
                    matrix[(row & 1) == 0 ? col : size - col - 1, row] = ++num;
        }

        private static void FillMatrixA(int[,] matrix, int size)
        {
            for (int row = 0, num = 0; row < size; row++)
                for (int col = 0; col < size; col++)
                    matrix[col, row] = ++num;
        }

        private static void Print(int[,] matrix, int size, bool reversed)
        {
            var output = new StringBuilder();

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    output.AppendFormat("{0} ", reversed ? matrix[col, row] : matrix[row, col]);
                }

                output.Length--;
                output.AppendLine();
            }

            Console.Write(output);
        }
    }
}