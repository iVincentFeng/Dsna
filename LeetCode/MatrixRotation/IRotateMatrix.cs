using System;

namespace Dsna.LeetCode.MatrixRotation
{
    interface IRotateMatrix<TValue> where TValue : IComparable
    {
        void RotateMatrix(TValue[,] matrix);
    }
}
