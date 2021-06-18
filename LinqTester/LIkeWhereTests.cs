using LinqOverData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTester
{
    [TestClass]
    public class LikeWhereTests
    {
        [TestMethod]
        public void TestIteration()
        {
            var result = LinqOverData.Quests.LikeWhere.Iterate(Airport.GetTheData());
            Assert.AreEqual(12205, result.Count);
        }

        [TestMethod]
        public void TestFunction()
        {
            var result = LinqOverData.Quests.LikeWhere.Function(Airport.GetTheData());
            Assert.AreEqual(12205, result.Count);
        }

        [TestMethod]
        public void TestLinq()
        {
            var result = LinqOverData.Quests.LikeWhere.Linq(Airport.GetTheData());
            Assert.AreEqual(12205, result.Count);
        }
    }
}
