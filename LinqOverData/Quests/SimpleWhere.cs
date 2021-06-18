using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverData.Quests
{
    /// <summary>
    /// Find all the airports in North America
    /// </summary>
    public class SimpleWhere
    {
        public static List<Airport> Iterate(List<Airport> airports)
        {
            var output = new List<Airport>();

            foreach (var airport in airports)
            {
                if (airport.Continent == "NA")
                {
                    output.Add(airport);
                }
            }

            return output;
        }

        public static List<Airport> Function(List<Airport> airports)
        {
            return airports.Where(x => x.Continent == "NA").ToList();
        }

        public static List<Airport> Linq(List<Airport> airports)
        {
            var query = from a in airports
                   where a.Continent == "NA"
                   select a;
            return query.ToList();
        }
    }
}
