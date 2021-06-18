using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverData
{
    public class Airport
    {
        public string Id { get; set; }
        public string Ident { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Continent { get; set; }
        public string IsoCountry { get; set; }
        public string Municipality { get; set; }

        public static List<Airport> GetTheData()
        {
            var lines = File.ReadAllLines("..\\..\\..\\airports.csv");

            var airports = new List<Airport>();
            int iteration = 0;
            foreach (var line in lines)
            {
                iteration++;
                if (iteration == 1)
                {
                    continue;
                }

                var pieces = line.Split(",");
                if (pieces.Length == 18)
                {
                    var ap = new Airport
                    {
                        Id = pieces[0],
                        Ident = pieces[1].Replace("\"", ""),
                        Type = pieces[2].Replace("\"", ""),
                        Name = pieces[3].Replace("\"", ""),
                        Latitude = pieces[4],
                        Longitude = pieces[5],
                        Continent = pieces[7].Replace("\"", ""),
                        IsoCountry = pieces[8].Replace("\"", ""),
                        Municipality = pieces[10].Replace("\"", "")
                    };
                    airports.Add(ap);
                }
            }

            return airports;
        }

    }
}


//"elevation_ft","continent","iso_country","iso_region","municipality","scheduled_service","gps_code","iata_code","local_code","home_link","wikipedia_link","keywords"
