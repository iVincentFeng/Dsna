using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dsna.LeetCode.ArrayRightRotation
{
    [TestClass()]
    public class ArrayRightRotationUt
    {
        [TestMethod()]
        public void Test_RightRotateArray_When_ArrayIsNullOrEmpty()
        {
            int[] array = null;
            this.arrayRightRotation.RightRotateArray(array, 1);
            Assert.IsNull(array);

            array = new int[] { };
            this.arrayRightRotation.RightRotateArray(array, 1);
            CollectionAssert.AreEqual(new int[] { }, array);
        }

        [TestMethod()]
        public void Test_RightRotateArray_When_ArrayIsNotEmptyAndOffsetIsLessThanOrEqualToZero()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] expectedArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            this.arrayRightRotation.RightRotateArray(array, -1);
            CollectionAssert.AreEqual(expectedArray, array);

            this.arrayRightRotation.RightRotateArray(array, 0);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [TestMethod()]
        public void Test_RightRotateArray_When_ArrayIsNotEmptyAndOffsetIsLessThanArrayLength()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] expectedArray = new int[] { 5, 6, 7, 1, 2, 3, 4 };

            this.arrayRightRotation.RightRotateArray(array, 3);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [TestMethod()]
        public void Test_RightRotateArray_When_ArrayIsNotEmptyAndOffsetIsEqualToArrayLength()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] expectedArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            this.arrayRightRotation.RightRotateArray(array, array.Length);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [TestMethod()]
        public void Test_RightRotateArray_When_ArrayIsNotEmptyAndOffsetIsGreaterThanArrayLength()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            this.arrayRightRotation.RightRotateArray(array, array.Length + 3);
            CollectionAssert.AreEqual(new int[] { 5, 6, 7, 1, 2, 3, 4 }, array);

            array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            this.arrayRightRotation.RightRotateArray(array, array.Length * 2);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6, 7 }, array);
        }

        private ArrayRightRotation<int> arrayRightRotation = new ArrayRightRotation<int>();
    }
}
