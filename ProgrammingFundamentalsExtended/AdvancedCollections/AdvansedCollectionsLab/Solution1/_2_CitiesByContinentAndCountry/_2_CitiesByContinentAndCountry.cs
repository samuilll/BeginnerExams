using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _2_CitiesByContinentAndCountry
{
    static void Main(string[] args)
    {
        var howManyTowns = int.Parse(Console.ReadLine());

        var SortedTownsAndCountries = new Dictionary<string, Dictionary<string, List<string>>>();

        for (int i = 0; i < howManyTowns; i++)
        {
            var input = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var contintent = input[0];

            var country = input[1];

            var town = input[2];

            AddTheTown(SortedTownsAndCountries, contintent, country, town);
        }

        PrintTheTownsLocationsList(SortedTownsAndCountries);
    }

    private static void PrintTheTownsLocationsList(Dictionary<string, Dictionary<string, List<string>>> sortedTownsAndCountries)
    {
        foreach (var continent in sortedTownsAndCountries.Keys)
        {
            Console.WriteLine($"{continent}:");

            foreach (var country in sortedTownsAndCountries[continent].Keys)
            {
                Console.WriteLine("  {0} -> {1}", country,string.Join(", ",sortedTownsAndCountries[continent][country]));
            }
        }
    }

    private static void AddTheTown(Dictionary<string, Dictionary<string, List<string>>> sortedTownsAndCountries, string contintent, string country, string town)
    {
        if (!sortedTownsAndCountries.ContainsKey(contintent))
        {
            sortedTownsAndCountries[contintent] = new Dictionary<string, List<string>>();
        }
        if (!sortedTownsAndCountries[contintent].ContainsKey(country))
        {
            sortedTownsAndCountries[contintent][country] = new List<string>();
        }
        sortedTownsAndCountries[contintent][country].Add(town);       
    }
}

