using LinqOverData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqTester
{
    [TestClass]
    public class SimpleWhereTests
    {
        [TestMethod]
        public void TestIteration()
        {
            var result = LinqOverData.Quests.SimpleWhere.Iterate(Airport.GetTheData());
            Assert.AreEqual(31238, result.Count);
        }

        [TestMethod]
        public void TestFunction()
        {
            var result = LinqOverData.Quests.SimpleWhere.Function(Airport.GetTheData());
            Assert.AreEqual(31238, result.Count);
        }

        [TestMethod]
        public void TestLinq()
        {
            var result = LinqOverData.Quests.SimpleWhere.Linq(Airport.GetTheData());
            Assert.AreEqual(31238, result.Count);
        }
    }
}
