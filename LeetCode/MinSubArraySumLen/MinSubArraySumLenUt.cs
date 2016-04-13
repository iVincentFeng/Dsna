using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Dsna.LeetCode.MinSubArraySumLen
{
    [TestClass()]
    public class MinSubArraySumLenUt
    {
        [TestMethod()]
        public void Test_GetMinSubArraySumLen()
        {
            this.TestGetMinSubArraySumLen(new uint[] { 2, 3, 1, 2, 4, 3 }, 7, 2);
        }

        [TestInitialize()]
        public void InitializeTest()
        {
            this.minSubArraySumLens.Add("MinSubArraySumLenWithSlidingWindow", new MinSubArraySumLenWithSlidingWindow());
            this.minSubArraySumLens.Add("MinSubArraySumLenWithBacktracking", new MinSubArraySumLenWithBacktracking());
        }

        private void TestGetMinSubArraySumLen(uint[] nums, uint sum, uint expectedResult)
        {
            foreach (KeyValuePair<string, IGetMinSubArraySumLen> minSubArraySumLen in this.minSubArraySumLens)
            {
                Assert.AreEqual<uint>(expectedResult, minSubArraySumLen.Value.GetMinSubArraySumLen(nums, sum));
            }
        }

        private Dictionary<string, IGetMinSubArraySumLen> minSubArraySumLens = new Dictionary<string, IGetMinSubArraySumLen>();
    }
}
