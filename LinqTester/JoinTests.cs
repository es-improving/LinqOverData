using LinqOverData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqTester
{
    [TestClass]
    public class JoinTests
    {
        [TestMethod]
        public void TestIteration()
        {
            var result = LinqOverData.Quests.Join.Iterate(Airport.GetTheData(), Continent.GetData());
            Assert.AreEqual(62114, result.Count);
            Assert.AreEqual("'S Gravenvoeren heliport", result[0].AirportName);
            Assert.AreEqual("Europe", result[0].ContinentFullName);
        }

        [TestMethod]
        public void TestFunction()
        {
            var result = LinqOverData.Quests.Join.Function(Airport.GetTheData(), Continent.GetData());
            Assert.AreEqual(62114, result.Count);
            Assert.AreEqual("'S Gravenvoeren heliport", result[0].AirportName);
            Assert.AreEqual("Europe", result[0].ContinentFullName);
        }

        [TestMethod]
        public void TestLinq()
        {
            var result = LinqOverData.Quests.Join.Linq(Airport.GetTheData(), Continent.GetData());
            Assert.AreEqual(62114, result.Count);
            Assert.AreEqual("'S Gravenvoeren heliport", result[0].AirportName);
            Assert.AreEqual("Europe", result[0].ContinentFullName);
        }
    }
}
