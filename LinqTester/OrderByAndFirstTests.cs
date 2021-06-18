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
    public class OrderByAndFirstTests
    {
        [TestMethod]
        public void TestFunction()
        {
            var result = LinqOverData.Quests.OrderByAndFirst.Function(Airport.GetTheData());
            Assert.AreEqual("'S Gravenvoeren heliport", result.Name);
        }

        [TestMethod]
        public void TestLinq()
        {
            var result = LinqOverData.Quests.OrderByAndFirst.Linq(Airport.GetTheData());
            Assert.AreEqual("'S Gravenvoeren heliport", result.Name);
        }
    }
}
