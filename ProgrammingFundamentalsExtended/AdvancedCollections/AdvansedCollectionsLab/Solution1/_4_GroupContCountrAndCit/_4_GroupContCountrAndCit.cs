using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_GroupContCountrAndCit
{
    class _4_GroupContCountrAndCit
    {
        static void Main(string[] args)
        {
            var howManyTowns = int.Parse(Console.ReadLine());

            var SortedChart = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < howManyTowns; i++)
            {
                var inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var continent = inputLine[0];
                var country = inputLine[1];
                var town = inputLine[2];

                AddTheTown(SortedChart, continent, country, town);

            }

            PrintTheSortedChart(SortedChart);
        }

        private static void PrintTheSortedChart(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> sortedChart)
        {
            foreach (var continent in sortedChart.Keys)
            {
                Console.WriteLine($"{continent}:");

                foreach (var country  in sortedChart[continent].Keys)
                {
                    Console.WriteLine("  {0} -> {1}", country, string.Join(", ", sortedChart[continent][country]));
                }
            }
        }

        private static void AddTheTown(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> sortedChart
            , string continent, string country, string town)
        {
            if (!sortedChart.ContainsKey(continent))
            {
                sortedChart[continent] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!sortedChart[continent].ContainsKey(country))
            {
                sortedChart[continent][country] = new SortedSet<string>();
            }
            sortedChart[continent][country].Add(town);
        }
    }
}
