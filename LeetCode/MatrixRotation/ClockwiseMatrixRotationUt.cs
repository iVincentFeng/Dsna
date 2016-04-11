using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dsna.LeetCode.MatrixRotation
{
    [TestClass()]
    public class ClockwiseMatrixRotationUt
    {
        [TestMethod()]
        public void Test_RotateMatrix_When_Matrix_IsNullOrEmpty()
        {
            int[,] matrix = null;
            this.matrixRotation.RotateMatrix(matrix);
            Assert.IsNull(matrix);

            matrix = new int[,] { };
            int[,] expectedMatrix = new int[,] { };
            this.matrixRotation.RotateMatrix(matrix);
            CollectionAssert.AreEqual(expectedMatrix, matrix);
        }

        [TestMethod()]
        public void Test_RotateMatrix_When_Matrix_HasOnly1Element()
        {
            int[,] matrix = new int[,] { { 1 } };
            int[,] expectedMatrix = new int[,] { { 1 } };
            this.matrixRotation.RotateMatrix(matrix);
            CollectionAssert.AreEqual(expectedMatrix, matrix);
        }

        [TestMethod()]
        public void Test_RotateMatrix_When_Matrix_HasDifferentDimensions()
        {
            int[,] matrix = new int[,] { { 1, 2 } };
            int[,] expectedMatrix = new int[,] { { 1, 2 } };
            this.matrixRotation.RotateMatrix(matrix);
            CollectionAssert.AreEqual(expectedMatrix, matrix);

            matrix = new int[,] { { 1 }, { 2 } };
            expectedMatrix = new int[,] { { 1 }, { 2 } };
            this.matrixRotation.RotateMatrix(matrix);
            CollectionAssert.AreEqual(expectedMatrix, matrix);
        }

        [TestMethod()]
        public void Test_RotateMatrix_When_Matrix_HasOddElements()
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

            this.matrixRotation.RotateMatrix(matrix);

            CollectionAssert.AreEqual(expectedMatrix, matrix);
        }

        [TestMethod()]
        public void Test_RotateMatrix_When_Matrix_HasEventElements()
        {
            int[,] matrix = new int[,]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            int[,] expectedMatrix = new int[,]
            {
                { 13, 9, 5, 1 },
                { 14, 10, 6, 2 },
                { 15, 11, 7, 3 },
                { 16, 12, 8, 4 }
            };

            this.matrixRotation.RotateMatrix(matrix);

            CollectionAssert.AreEqual(expectedMatrix, matrix);
        }

        private ClockwiseMatrixRotation<int> matrixRotation = new ClockwiseMatrixRotation<int>();
    }
}
