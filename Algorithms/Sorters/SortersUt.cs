using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Dsna.Algorithms.Shared;

namespace Dsna.Algorithms.Sorters
{
    [TestClass()]
    public class SortersUt
    {
        [TestMethod()]
        public void Test_Sort_When_ArrayIsNullOrEmpty()
        {
            this.TestSortersWithArray(null, null);
            this.TestSortersWithArray(new int[] { }, new int[] { });
        }

        [TestMethod()]
        public void Test_Sort_When_ArrayHasOnly1Element()
        {
            this.TestSortersWithArray(new int[] { 1 }, new int[] { 1 });
        }

        [TestMethod()]
        public void Test_Sort_With_VariousArrays()
        {
            this.TestSortersWithArray(new int[] { 8, 2, 4, 9, 3, 6 }, new int[] { 2, 3, 4, 6, 8, 9 });
            this.TestSortersWithArray(new int[] { 8, 2, 4, 4, 4, 6 }, new int[] { 2, 4, 4, 4, 6, 8 });
            this.TestSortersWithArray(new int[] { 2, 3, 4, 6, 8, 9 }, new int[] { 2, 3, 4, 6, 8, 9 });
            this.TestSortersWithArray(new int[] { 9, 8, 6, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 6, 8, 9 });
            this.TestSortersWithArray(new int[] { 917, 632, 213, 37, 89, 24, 1 }, new int[] { 1, 24, 37, 89, 213, 632, 917 });
        }

        [TestInitialize()]
        public void InitializeTest()
        {
            this.sorters.Add("InsertionSorter", new InsertionSorter<int>());
            this.sorters.Add("BinaryInsertionSorter", new BinaryInsertionSorter<int>());
            this.sorters.Add("QuickSorter with LowerBoundPivotSelector", new QuickSorter<int>(new LowerBoundPivotSelector<int>()));
            this.sorters.Add("QuickSorter with UpperBoundPivotSelector", new QuickSorter<int>(new UpperBoundPivotSelector<int>()));
        }

        private void TestSortersWithArray(int[] array, int[] expectedResultArray)
        {
            foreach (KeyValuePair<string, ISort<int>> sorter in this.sorters)
            {
                int[] tempArray = null;

                if (array != null)
                {
                    tempArray = new int[array.Length];
                    array.CopyTo(tempArray, 0);
                }

                sorter.Value.Sort(tempArray);

                if ((tempArray != null) && (expectedResultArray != null))
                {
                    CollectionAssert.AreEqual(expectedResultArray, tempArray);
                }
            }
        }

        private Dictionary<string, ISort<int>> sorters = new Dictionary<string, ISort<int>>();
    }
}