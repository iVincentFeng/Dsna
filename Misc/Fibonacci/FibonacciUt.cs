using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Dsna.Misc.Fibonacci
{
    [TestClass()]
    public class FibonacciUt
    {
        [TestMethod()]
        public void Test_CalculateFibonacci_When_NumberIsZeroOrOne()
        {
            this.TestCalculateFibonacci(0, 0);
            this.TestCalculateFibonacci(1, 1);
        }

        [TestMethod()]
        public void Test_CalculateFibonacci_With_VariousNumbers()
        {
            this.TestCalculateFibonacci(8, 21);
            this.TestCalculateFibonacci(18, 2584);
            this.TestCalculateFibonacci(28, 317811);
        }

        [TestInitialize()]
        public void InitializeTest()
        {
            this.fibonaccis.Add("RecursiveFibonacci", new RecursiveFibonacci());
            this.fibonaccis.Add("RecursiveFibonacciWithCache", new RecursiveFibonacciWithCache());
            this.fibonaccis.Add("IterativeFibonacci", new IterativeFibonacci());
        }

        private void TestCalculateFibonacci(uint number, ulong expectedResult)
        {
            foreach (KeyValuePair<string, IFibonacci> fibonacci in this.fibonaccis)
            {
                Assert.AreEqual<ulong>(expectedResult, fibonacci.Value.CalculateFibonacci(number));
            }
        }

        private Dictionary<string, IFibonacci> fibonaccis = new Dictionary<string, IFibonacci>();
    }
}
