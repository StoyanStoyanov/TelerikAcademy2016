namespace GenericMatrixImplementation
{
    using System;
    using System.Text;

    public class GenericMatrix<T>
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {

        private readonly T[,] elements;
        private readonly int rows;
        private readonly int cols;

        public GenericMatrix()
        {
            this.rows = 0;
            this.cols = 0;
            this.elements = new T[rows, cols];
        }

        public GenericMatrix(int firstDimensionLength, int secondDimensionLength)
        {
            if (rows < 0 || cols < 0)
            {
                throw new ArgumentOutOfRangeException("Matrix dimensions cannot be negative numbers!");
            }

            this.rows = firstDimensionLength;
            this.cols = secondDimensionLength;
            this.elements = new T[this.rows, this.cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
        }

        public int Length 
        {
            get
            {
                return this.rows * this.cols;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if (row >= this.rows || row < 0)
                {
                    throw new IndexOutOfRangeException("Row is out of the range of the Matrix's upper bound.");
                }

                if (col >= this.cols || col < 0)
                {
                    throw new IndexOutOfRangeException("Col is out of the range of the Matrix's lower bound.");
                }

                return this.elements[row, col];
            }

            set
            {
                if (row >= this.rows || row < 0)
                {
                    throw new IndexOutOfRangeException("Row is out of the range of the Matrix's upper bound.");
                }

                if (col >= this.cols || col < 0)
                {
                    throw new IndexOutOfRangeException("Col is out of the range of the Matrix's lower bound.");
                }

                this.elements[row, col] = value;
            }
        }

        public static GenericMatrix<T> operator +(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            return Add(firstMatrix, secondMatrix);
        }

        public static GenericMatrix<T> operator -(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            return Substract(firstMatrix, secondMatrix);
        }

        public static GenericMatrix<T> operator *(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            return Multiply(firstMatrix, secondMatrix);
        }

        public static bool operator true(GenericMatrix<T> matrix)
        {
            if (matrix == null || matrix.rows == 0 || matrix.cols == 0)
            {
                return false;
            }

            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if (!matrix[row, col].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(GenericMatrix<T> matrix)
        {
            if (matrix == null || matrix.rows == 0 || matrix.cols == 0)
            {
                return true;
            }

            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if (!matrix[row, col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public int GetLength(int dimension)
        {
            switch (dimension)
            {
                case 0: 
                    return this.rows;
                case 1: 
                    return this.cols;
                default: 
                    throw new ArgumentException("The matrix has only 2 dimensions, labelled 0 and 1, respectively.");
            }
        }

        private static GenericMatrix<T> Add(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            var type = typeof(T);

            if (type == typeof(DateTime))
            {
                throw new ArgumentException(string.Format("Addition of matrices of {0} type is not supported!", type.FullName), "T");
            }

            if (firstMatrix.Length != secondMatrix.Length)
            {
                throw new ArgumentException("Addition of matrices of different sizes is not supported!");
            }

            var result = new GenericMatrix<T>(firstMatrix.GetLength(0), firstMatrix.GetLength(1));

            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int col = 0; col < result.GetLength(1); col++)
                {
                    result[row, col] = ((dynamic)firstMatrix[row, col] + (dynamic)secondMatrix[row, col]);
                }
            }

            return result;
        }

        private static GenericMatrix<T> Substract(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            var type = typeof(T);

            if (type == typeof(DateTime))
            {
                throw new ArgumentException(string.Format("Substraction of matrices of {0} type is not supported!", type.FullName), "T");
            }

            if (firstMatrix.Length != secondMatrix.Length)
            {
                throw new ArgumentException("Substraction of matrices of different sizes is not supported!");
            }

            var result = new GenericMatrix<T>(firstMatrix.GetLength(0), firstMatrix.GetLength(1));

            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int col = 0; col < result.GetLength(1); col++)
                {
                    result[row, col] = ((dynamic)firstMatrix[row, col] - (dynamic)secondMatrix[row, col]);
                }
            }

            return result;
        }

        private static GenericMatrix<T> Multiply(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            var type = typeof(T);

            if (type == typeof(DateTime))
            {
                throw new ArgumentException(String.Format("Multiplication of matrices of {0} type is not supported!", type.FullName), "T");
            }

            if (firstMatrix.Length != secondMatrix.Length)
            {
                throw new ArgumentException("Multiplication of matrices of different sizes is not supported!");
            }

            var result = new GenericMatrix<T>(firstMatrix.GetLength(0), firstMatrix.GetLength(1));

            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int col = 0; col < result.GetLength(1); col++)
                {
                    result[row, col] = ((dynamic)firstMatrix[row, col] * (dynamic)secondMatrix[row, col]);
                }
            }

            return result;
        }

        public override string ToString()
        {
            var matrixInfo = new StringBuilder();

            for (int row = 0; row < this.GetLength(0); row++)
            {
                for (int col = 0; col < this.GetLength(1); col++)
                {
                    matrixInfo.AppendFormat("{0, 3} ", this[row, col]);
                }

                matrixInfo.AppendLine();
            }

            return matrixInfo.ToString();
        }
    }
}