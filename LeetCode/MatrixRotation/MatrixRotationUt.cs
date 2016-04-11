using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Dsna.LeetCode.MatrixRotation
{
    [TestClass()]
    public class MatrixRotationUt
    {
        //[TestMethod()]
        //public void Test_RotateMatrix_When_Matrix_IsNullOrEmpty()
        //{
        //}

        [TestMethod()]
        public void Test_RotateMatrix()
        {
            int[,] matrix = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] expectedMatrix = new int[,]
            {
                { 7, 4, 1 },
                { 8, 5, 2 },
                { 9, 6, 3 }
            };

            this.TestRotateMatrix(matrix, expectedMatrix);
        }

        [TestInitialize()]
        public void InitializeTest()
        {
            this.matrixRotations.Add("ClockwiseMatrixRotation", new ClockwiseMatrixRotation<int>());
        }

        private void TestRotateMatrix(int[,] matrix, int[,] expectedMatrix)
        {
            foreach (KeyValuePair<string, IRotateMatrix<int>> matrixRotation in this.matrixRotations)
            {
                matrixRotation.Value.RotateMatrix(matrix);

                CollectionAssert.AreEqual(matrix, expectedMatrix);
            }
        }

        private Dictionary<string, IRotateMatrix<int>> matrixRotations = new Dictionary<string, IRotateMatrix<int>>();
    }
}
