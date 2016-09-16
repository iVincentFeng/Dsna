using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Dsna.Misc.MathematicalExpressionParser
{
    [TestClass()]
    public class MathematicalExpressionParserUt
    {
        [TestMethod()]
        public void Test_Parse()
        {
            this.TestParsers("(1 + ((2 + 3) * (4 * 5)))", 101);
            this.TestParsers("(1 + (2 + 3) * (4 * 5))", 101);
        }

        [TestInitialize()]
        public void InitializeTest()
        {
            this.parsers.Add("Dijkstra2StackParser", new Dijkstra2StackParser());
        }

        private void TestParsers(string expression, double expectedResult)
        {
            foreach (KeyValuePair<string, IParseMathematicalExpression> parser in this.parsers)
            {
                Assert.AreEqual<double>(expectedResult, parser.Value.Parse(expression));
            }
        }

        private Dictionary<string, IParseMathematicalExpression> parsers = new Dictionary<string, IParseMathematicalExpression>();
    }
}
