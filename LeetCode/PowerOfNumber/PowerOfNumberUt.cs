using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dsna.LeetCode.PowerOfNumber
{
    [TestClass()]
    public class PowerOfNumberUt
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Power_When_NumberIsZeroAndPowerIsLessThanZero()
        {
            this.powerOfNumber.Power(0.00d, -1);
        }

        [TestMethod()]
        public void Test_Power_When_NumberIsZeroAndPowerIsEqualToOrGreaterThanZero()
        {
            Assert.AreEqual<double>(0.00d, this.powerOfNumber.Power(0.00d, 0));
            Assert.AreEqual<double>(0.00d, this.powerOfNumber.Power(0.00d, 1));
        }

        [TestMethod()]
        public void Test_Power_When_NumberIsNotZeroAndPowerIsZero()
        {
            Assert.AreEqual<double>(1.00d, this.powerOfNumber.Power(8.00d, 0));
        }

        [TestMethod()]
        public void Test_Power_When_NumberIsNotZeroAndPowerIsPositive()
        {
            Assert.AreEqual<double>(8.00d, this.powerOfNumber.Power(2.00d, 3));
        }

        [TestMethod()]
        public void Test_Power_When_NumberIsNotZeroAndPowerIsNegative()
        {
            Assert.AreEqual<double>(0.125d, this.powerOfNumber.Power(2.00d, -3));
        }

        private PowerOfNumber powerOfNumber = new PowerOfNumber();
    }
}
