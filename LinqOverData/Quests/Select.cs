using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverData.Quests
{
    /// <summary>
    /// Find all the airport names in Europe
    /// </summary>
    public class Select
    {
        public static List<string> Iterate(List<Airport> airports)
        {
            var output = new List<string>();

            foreach (var airport in airports)
            {
                if (airport.Continent == "EU")
                {
                    output.Add(airport.Name);
                }
            }

            return output;
        }

        public static List<string> Function(List<Airport> airports)
        {
            return airports.Where(a => a.Continent == "EU").Select(a => a.Name).ToList();
        }

        public static List<string> Linq(List<Airport> airports)
        {
            var query = from a in airports
                    where a.Continent == "EU"
                    select a.Name;
            return query.ToList();
        }
    }
}
