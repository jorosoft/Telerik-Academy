namespace DefiningClassesPartTwo
{
    using System;

    public class Matrix<T>
    {
        private int rowsCount;
        private int colsCount;
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.rowsCount = rows;
            this.colsCount = cols;
            this.matrix = new T[rows, cols];
        }

        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }

            set
            {
                if (row < 0 || col < 0 || row >= this.matrix.GetLength(0) || col >= this.matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException();
                }

                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator + (Matrix<T> firstMatrix, Matrix<T> secondMartix)
        {
            if ((firstMatrix.matrix.GetLength(0) != secondMartix.matrix.GetLength(0)) ||
                (firstMatrix.matrix.GetLength(1) != secondMartix.matrix.GetLength(1)))
            {
                throw new ArgumentException("Matrices are not with equal dimmensions!");
            }

            var resultMatrix = new Matrix<T>(firstMatrix.matrix.GetLength(0), firstMatrix.matrix.GetLength(1));
            for (int row = 0; row < resultMatrix.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < resultMatrix.matrix.GetLength(1); col++)
                {
                    resultMatrix.matrix[row, col] = (dynamic)firstMatrix.matrix[row, col] + (dynamic)secondMartix.matrix[row, col];
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator - (Matrix<T> firstMatrix, Matrix<T> secondMartix)
        {
            if ((firstMatrix.matrix.GetLength(0) != secondMartix.matrix.GetLength(0)) ||
                            (firstMatrix.matrix.GetLength(1) != secondMartix.matrix.GetLength(1)))
            {
                throw new ArgumentException("Matrices are not with equal dimmensions!");
            }

            var resultMatrix = new Matrix<T>(firstMatrix.matrix.GetLength(0), firstMatrix.matrix.GetLength(1));
            for (int row = 0; row < resultMatrix.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < resultMatrix.matrix.GetLength(1); col++)
                {
                    resultMatrix.matrix[row, col] = (dynamic)firstMatrix.matrix[row, col] - (dynamic)secondMartix.matrix[row, col];
                }
            }
            
            return resultMatrix;
        }

        public static Matrix<T> operator * (Matrix<T> firstMatrix, Matrix<T> secondMartix)
        {
            if (firstMatrix.matrix.GetLength(1) != secondMartix.matrix.GetLength(0))
            {
                throw new ArgumentException("Matrices can't be multiplied with incompatible dimmensions!");
            }

            var resultMatrix = new Matrix<T>(firstMatrix.matrix.GetLength(0), secondMartix.matrix.GetLength(1));
            for (int row = 0; row < resultMatrix.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < resultMatrix.matrix.GetLength(1); col++)
                {
                    resultMatrix.matrix[row, col] = (dynamic)0;
                    for (int i = 0; i < firstMatrix.matrix.GetLength(1); i++)
                    {
                        resultMatrix.matrix[row, col] += (dynamic)firstMatrix.matrix[row, i] * (dynamic)secondMartix.matrix[i, col]; 
                    }                   
                }                
            }

            return resultMatrix;
        }   
        
        public static bool operator true(Matrix<T> currentMatrix)
        {
            var result = true;
            for (int row = 0; row < currentMatrix.rowsCount; row++)
            {
                for (int col = 0; col < currentMatrix.colsCount; col++)
                {
                    if (currentMatrix.matrix[row, col] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return result;
        }

        public static bool operator false(Matrix<T> currentMatrix)
        {
            var result = false;
            for (int row = 0; row < currentMatrix.rowsCount; row++)
            {
                for (int col = 0; col < currentMatrix.colsCount; col++)
                {
                    if (currentMatrix.matrix[row, col] == (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return result;
        }
    }
}
