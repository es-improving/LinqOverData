using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverData.Quests
{
    /// <summary>
    /// What's the first airport in the set alphabetically by name?
    /// </summary>
    public class OrderByAndFirst
    {
        public static Airport Iterate(List<Airport> airports)
        {
            // Nope, not even
            // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=net-5.0
            return null;
        }

        public static Airport Function(List<Airport> airports)
        {
            return airports.OrderBy(x => x.Name).First();
        }

        public static Airport Linq(List<Airport> airports)
        {
            var query = from a in airports
                   orderby a.Name
                   select a;
            return query.First();
        }
    }
}
