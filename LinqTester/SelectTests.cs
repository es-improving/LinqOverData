using LinqOverData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqTester
{
    [TestClass]
    public class SelectTests
    {
        [TestMethod]
        public void TestIteration()
        {
            var result = LinqOverData.Quests.Select.Iterate(Airport.GetTheData());
            Assert.AreEqual(8108, result.Count);
        }

        [TestMethod]
        public void TestFunction()
        {
            var result = LinqOverData.Quests.Select.Function(Airport.GetTheData());
            Assert.AreEqual(8108, result.Count);
        }

        [TestMethod]
        public void TestLinq()
        {
            var result = LinqOverData.Quests.Select.Linq(Airport.GetTheData());
            Assert.AreEqual(8108, result.Count);
        }
    }
}
