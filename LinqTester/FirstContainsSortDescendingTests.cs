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
    public class FirstContainsSortDescendingTests
    {
        [TestMethod]
        public void TestFunction()
        {
            var result = LinqOverData.Quests.FirstContainsSortDescending.Function(Airport.GetTheData());
            Assert.AreEqual("Yanomami Airstrip", result.Name);
        }

        [TestMethod]
        public void TestLinq()
        {
            var result = LinqOverData.Quests.FirstContainsSortDescending.Linq(Airport.GetTheData());
            Assert.AreEqual("Yanomami Airstrip", result.Name);
        }
    }
}
