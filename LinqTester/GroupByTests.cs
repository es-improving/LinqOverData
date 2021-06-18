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
    public class GroupByTests
    {
        private static Dictionary<string, int> _continentCounts = new Dictionary<string, int>
        {
            { "NA", 31238 },
            { "OC", 3091 },
            { "AF", 3469 },
            { "AN", 41 },
            { "EU", 8108 },
            { "AS", 7029 },
            { "SA", 9138 }
        };

        [TestMethod]
        public void TestIteration()
        {
            var result = LinqOverData.Quests.GroupBy.Iterate(Airport.GetTheData());
            foreach (var key in result.Keys)
            {
                var count = result[key].Count;

                Assert.AreEqual(_continentCounts[key], count);
            }
        }

        [TestMethod]
        public void TestFunction()
        {
            var result = LinqOverData.Quests.GroupBy.Function(Airport.GetTheData());
            foreach (var airportGroup in result)
            {
                var key = airportGroup.Key;
                var count = airportGroup.Count();

                Assert.AreEqual(_continentCounts[key], count);
            }
        }

        [TestMethod]
        public void TestLinq()
        {
            var result = LinqOverData.Quests.GroupBy.Linq(Airport.GetTheData());
            foreach (var airportGroup in result)
            {
                var key = airportGroup.Key;
                var count = airportGroup.Count();

                Assert.AreEqual(_continentCounts[key], count);
            }
        }
    }
}
