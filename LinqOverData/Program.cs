using LinqOverData.Quests;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace LinqOverData
{
    class Program
    {
        static void Main(string[] args)
        {
            var airports = Airport.GetTheData();

            //var output = LikeWhere.Linq(airports);
            //PrintAirports(output);
        }

        static void PrintAirports(List<Airport> airports)
        {
            foreach (var airport in airports)
            {
                Console.WriteLine($"{airport.Name},{airport.Continent}");
            }
        }
    }
}
