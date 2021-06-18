using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverData.Quests
{
    /// <summary>
    /// Find all the airports that have the word "Heliport" in their name
    /// </summary>
    public class LikeWhere
    {
        public static List<Airport> Iterate(List<Airport> airports)
        {
            var output = new List<Airport>();

            foreach (var airport in airports)
            {
                if (airport.Name.Contains("Heliport"))
                {
                    output.Add(airport);
                }
            }

            return output;
        }

        public static List<Airport> Function(List<Airport> airports)
        {
            return airports.Where(a => a.Name.Contains("Heliport")).ToList();
        }

        public static List<Airport> Linq(List<Airport> airports)
        {
            var query = from a in airports
                         where a.Name.Contains("Heliport")
                         select a;
            return query.ToList();
        }
    }
}
