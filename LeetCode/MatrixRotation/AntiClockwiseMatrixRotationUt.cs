using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dsna.LeetCode.MatrixRotation
{
    [TestClass()]
    public class AntiClockwiseMatrixRotationUt
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
                { 3, 6, 9 },
                { 2, 5, 8 },
                { 1, 4, 7 }
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
                { 4, 8, 12, 16 },
                { 3, 7, 11, 15 },
                { 2, 6, 10, 14 },
                { 1, 5, 9, 13 }
            };

            this.matrixRotation.RotateMatrix(matrix);

            CollectionAssert.AreEqual(expectedMatrix, matrix);
        }

        private AntiClockwiseMatrixRotation<int> matrixRotation = new AntiClockwiseMatrixRotation<int>();
    }
}
