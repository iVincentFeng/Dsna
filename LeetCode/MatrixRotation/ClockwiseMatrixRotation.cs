using System;

namespace Dsna.LeetCode.MatrixRotation
{
    /// <summary>
    /// https://leetcode.com/problems/rotate-image/
    /// </summary>
    /// <typeparam name="TValue">Type of value, should implement IComparable</typeparam>
    public class ClockwiseMatrixRotation<TValue> : IRotateMatrix<TValue> where TValue : IComparable
    {
        public void RotateMatrix(TValue[,] matrix)
        {
            if (matrix == null)
            {
                return;
            }

            int dimLen1 = matrix.GetLength(0);
            int dimLen2 = matrix.GetLength(1);

            if ((dimLen1 <= 1) || (dimLen2 <= 1) || (dimLen1 != dimLen2))
            {
                return;
            }

            this.DoVerticalFlip(matrix);
            this.DoDiagonalFlip(matrix);
        }

        private void DoVerticalFlip(TValue[,] matrix)
        {
            int dimLen = matrix.GetLength(0);

            for (int ixRow = 0; ixRow < dimLen / 2; ixRow++)
            {
                for (int ixColumn = 0; ixColumn < dimLen; ixColumn++)
                {
                    this.Swap(matrix, ixRow, ixColumn, dimLen - ixRow - 1, ixColumn);
                }
            }
        }

        private void DoDiagonalFlip(TValue[,] matrix)
        {
            int dimLen = matrix.GetLength(0);

            for (int ixRow = 0; ixRow < dimLen; ixRow++)
            {
                for (int ixColumn = 0; ixColumn < ixRow; ixColumn++)
                {
                    this.Swap(matrix, ixRow, ixColumn, ixColumn, ixRow);
                }
            }
        }

        private void Swap(TValue[,] matrix, int rowIdxA, int columnIdxA, int rowIdxB, int columnIdxB)
        {
            if ((rowIdxA == rowIdxB) && (columnIdxA == columnIdxB))
            {
                return;
            }

            TValue temp = matrix[rowIdxA, columnIdxA];
            matrix[rowIdxA, columnIdxA] = matrix[rowIdxB, columnIdxB];
            matrix[rowIdxB, columnIdxB] = temp;
        }
    }
}
