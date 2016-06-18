namespace GenericMatrixImplementation
{
    using System;

    public class GenericMatrixImplementation
    {
        public static void Main()
        {
            try
            {
                // Create a few instances of the GeneriMatrix class
                var firstMatrix = new GenericMatrix<int>(5, 5);
                var secondMatrix = new GenericMatrix<int>(5, 5);
                var emptyMatrix = new GenericMatrix<int>();

                // Fill the first two of them with numbers from 1 to 25
                for (int row = 0, p = 0, t = 0; row < firstMatrix.GetLength(0); row++)
                {
                    for (int col = 0; col < firstMatrix.GetLength(1); col++)
                    {
                        firstMatrix[row, col] = ++p;
                        secondMatrix[row, col] = ++t;
                    }
                }

                // Print the two test matrices
                Console.WriteLine("======== First Matrix ======== \n\n{0}", firstMatrix);
                Console.WriteLine("======= Second Matrix ======= \n\n{0}", secondMatrix);
                Console.WriteLine("======== Empty Matrix ======== \n\n{0}", emptyMatrix);

                // Test how operators work and print the result of the operations
                Console.WriteLine("======== Addition of matrices ======== \n\n{0}", firstMatrix + secondMatrix);
                Console.WriteLine("======== Substraction of matrices ======== \n\n{0}", firstMatrix - secondMatrix);
                Console.WriteLine("======== Multiplication of matrices ======== \n\n{0}", firstMatrix * secondMatrix);

                // Test true operator with an empty matrix
                if (emptyMatrix)
                {
                    Console.WriteLine("The matrix has non-zero elements.");
                }
                else
                {
                    Console.WriteLine("The matrix is null or it's elements are empty.");
                }

                // Test true operator with a non-empty matrix
                if (firstMatrix)
                {
                    Console.WriteLine("The matrix has non-zero elements.");
                }
                else
                {
                    Console.WriteLine("The matrix is null or it's elements are empty.");
                }
            }
            catch (ArgumentOutOfRangeException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
