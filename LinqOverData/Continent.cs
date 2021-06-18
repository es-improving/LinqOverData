using System;
using System.Collections.Generic;

namespace LinqOverData
{
    public class Continent
    {
        public string Abbreviation { get; set; }
        public string Name { get; set; }

        public static List<Continent> GetData()
        {
            return new List<Continent>
            {
                new Continent { Abbreviation = "NA", Name = "North America" },
                new Continent { Abbreviation = "OC", Name = "Oceania" },
                new Continent { Abbreviation = "AF", Name = "Africa" },
                new Continent { Abbreviation = "AN", Name = "Antarctica" },
                new Continent { Abbreviation = "EU", Name = "Europe" },
                new Continent { Abbreviation = "AS", Name = "Asia" },
                new Continent { Abbreviation = "SA", Name = "South America" }
            };
        }
    }
}