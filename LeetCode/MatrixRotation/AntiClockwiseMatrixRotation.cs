using System;

namespace Dsna.LeetCode.MatrixRotation
{
    /// <summary>
    /// https://leetcode.com/problems/rotate-image/
    /// Follow up question
    /// </summary>
    /// <typeparam name="TValue">Type of value, should implement IComparable</typeparam>
    public class AntiClockwiseMatrixRotation<TValue> : IRotateMatrix<TValue> where TValue : IComparable
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

            this.DoHorizontalFlip(matrix);
            this.DoDiagonalFlip(matrix);
        }

        private void DoHorizontalFlip(TValue[,] matrix)
        {
            int dimLen = matrix.GetLength(0);

            for (int ixRow = 0; ixRow < dimLen; ixRow++)
            {
                for (int ixColumn = 0; ixColumn < dimLen / 2; ixColumn++)
                {
                    this.Swap(matrix, ixRow, ixColumn, ixRow, dimLen - ixColumn - 1);
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
