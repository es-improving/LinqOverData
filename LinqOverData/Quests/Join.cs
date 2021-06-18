using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverData.Quests
{
    /// <summary>
    /// Find all the airports, join onto the continents to return full continent name, order by airport name ascending, return airport join object.
    /// </summary>
    public class Join
    {
        public static List<AirportJoin> Iterate(List<Airport> airports, List<Continent> continents)
        {
            var output = new List<AirportJoin>();

            foreach (var airport in airports)
            {
                output.Add(new AirportJoin
                {
                    AirportName = airport.Name,
                    ContinentFullName = continents.First(c => c.Abbreviation == airport.Continent).Name
                });
            }

            return output.OrderBy(j => j.AirportName).ToList();
        }

        public static List<AirportJoin> Function(List<Airport> airports, List<Continent> continents)
        {
            var query = airports.OrderBy(a => a.Name).Join(continents, a => a.Continent, c => c.Abbreviation, (airport, continent) =>
            {
                return new AirportJoin { AirportName = airport.Name, ContinentFullName = continent.Name };
            });

            return query.ToList();
        }

        public static List<AirportJoin> Linq(List<Airport> airports, List<Continent> continents)
        {
            var query = from a in airports
                        join c in continents on a.Continent equals c.Abbreviation
                   orderby a.Name
                   select new AirportJoin { AirportName = a.Name, ContinentFullName = c.Name };
            return query.ToList();
        }
    }
}
