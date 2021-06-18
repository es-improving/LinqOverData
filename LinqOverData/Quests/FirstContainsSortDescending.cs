using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverData.Quests
{
    /// <summary>
    /// Find the last airport (ordered by name descending) that contains "airstrip" in name and is in Brazil
    /// </summary>
    public class FirstContainsSortDescending
    {
        public static Airport Iterate(List<Airport> airports)
        {
            // Still a nope
            return null;
        }

        public static Airport Function(List<Airport> airports)
        {
            return airports.Where(x => x.Name.Contains("Airstrip")).Where(a => a.IsoCountry == "BR").OrderByDescending(a => a.Name).First();
        }

        public static Airport Linq(List<Airport> airports)
        {
            var query = from a in airports
                   where a.Name.Contains("Airstrip") && a.IsoCountry == "BR"
                   orderby a.Name descending
                   select a;
            return query.First();
        }
    }
}
