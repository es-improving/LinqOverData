using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverData.Quests
{
    /// <summary>
    /// Group all the airports by continent
    /// </summary>
    public class GroupBy
    {
        public static Dictionary<string, List<Airport>> Iterate(List<Airport> airports)
        {
            var output = new Dictionary<string, List<Airport>>();

            foreach (var airport in airports)
            {
                if (!output.ContainsKey(airport.Continent))
                {
                    output[airport.Continent] = new List<Airport>();
                }

                output[airport.Continent].Add(airport);
            }

            return output;
        }

        public static IEnumerable<IGrouping<string, Airport>> Function(List<Airport> airports)
        {
            return airports.GroupBy(x => x.Continent);
        }

        public static IEnumerable<IGrouping<string, Airport>> Linq(List<Airport> airports)
        {
            var query = from a in airports
                        group a by a.Continent;
            return query;
        }
    }
}
