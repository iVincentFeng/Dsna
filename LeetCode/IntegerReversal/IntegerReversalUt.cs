using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dsna.LeetCode.IntegerReversal
{
    [TestClass()]
    public class IntegerReversalUt
    {
        [TestMethod()]
        public void Test_ReverseInteger_When_IntegerIsZero()
        {
            Assert.AreEqual<int>(0, this.integerReversal.ReverseInteger(0));
        }

        [TestMethod()]
        public void Test_ReverseInteger_When_IntegerIsPositive()
        {
            Assert.AreEqual<int>(321, this.integerReversal.ReverseInteger(123));
        }

        [TestMethod()]
        public void Test_ReverseInteger_When_ResultExceedsIntMaxValue()
        {
            Assert.AreEqual<int>(int.MaxValue, this.integerReversal.ReverseInteger(int.MaxValue));
        }

        [TestMethod()]
        public void Test_ReverseInteger_When_IntegerIsNegative()
        {
            Assert.AreEqual<int>(-321, this.integerReversal.ReverseInteger(-123));
        }

        [TestMethod()]
        public void Test_ReverseInteger_When_ResultExceedsIntMinValue()
        {
            Assert.AreEqual<int>(int.MinValue, this.integerReversal.ReverseInteger(int.MinValue));
        }

        private IntegerReversal integerReversal = new IntegerReversal();
    }
}
