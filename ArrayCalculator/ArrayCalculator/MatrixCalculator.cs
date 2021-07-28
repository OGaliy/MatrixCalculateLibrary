﻿namespace MatrixCalculateLibrary
{
    public static class MatrixCalculator
    {
        /// <summary>
        /// Calculates cofactor matrix.
        /// </summary>
        /// <param name="rowIndex">Index of row element(starts from 0)</param>
        /// <param name="columnIndex">Index of column element(starts from 0)</param>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Cofactor matrix</returns>
        public static double[,] CalculateCofactorMatrix(int rowIndex, int columnIndex, double[,] matrix)
        {
            int r = 0;
            int length = matrix.GetLength(0);

            if (length != matrix.GetLength(1))
            {
                throw new MatrixExeption(Constants.NotSquareException);
            }

            double[,] result = new double[length - 1, length - 1];

            for (int i = 0; i < length; i++)
            {
                int c = 0;

                for (int j = 0; j < length; j++)
                {
                    if (i != rowIndex && j != columnIndex)
                    {
                        result[r, c] = matrix[i, j];
                        c++;
                    }
                }
                if (i != rowIndex)
                {
                    r++;
                }
            }

            return result;
        }

        /// <summary>
        /// Calculates cofactor matrix.
        /// </summary>
        /// <param name="rowIndex">Index of row element(starts from 0)</param>
        /// <param name="columnIndex">Index of column element(starts from 0)</param>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Cofactor matrix</returns>
        public static int[,] CalculateCofactorMatrix(int rowIndex, int columnIndex, int[,] matrix)
        {
            int r = 0;
            int length = matrix.GetLength(0);

            if (length != matrix.GetLength(1))
            {
                throw new MatrixExeption(Constants.NotSquareException);
            }

            int[,] result = new int[length - 1, length - 1];

            for (int i = 0; i < length; i++)
            {
                int c = 0;

                for (int j = 0; j < length; j++)
                {
                    if (i != rowIndex && j != columnIndex)
                    {
                        result[r, c] = matrix[i, j];
                        c++;
                    }
                }
                if (i != rowIndex)
                {
                    r++;
                }
            }

            return result;
        }

        /// <summary>
        /// Calculates transpose matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Transposed matrix</returns>
        public static double[,] CalculateTransposeMatrix(double[,] matrix)
        {
            int length = matrix.GetLength(0);

            if (length != matrix.GetLength(1))
            {
                throw new MatrixExeption(Constants.NotSquareException);
            }

            double[,] result = new double[length, length];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }

            return result;
        }

        /// <summary>
        /// Calculates transpose matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Transposed matrix</returns>
        public static int[,] CalculateTransposeMatrix(int[,] matrix)
        {
            int length = matrix.GetLength(0);

            if (length != matrix.GetLength(1))
            {
                throw new MatrixExeption(Constants.NotSquareException);
            }

            int[,] result = new int[length, length];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }

            return result;
        }
    }
}
