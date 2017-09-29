using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_CottageScraper
{
    class _6_CottageScraper
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine()
           .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            var treesList = new Dictionary<string, List<int>>();

            while (inputLine[0] != "chop")
            {
                var treeType = inputLine[0];

                var treeHeight = int.Parse(inputLine[1]);

                AddToTreesList(treesList, treeType, treeHeight);

                inputLine = Console.ReadLine()
                          .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var wantedType = Console.ReadLine();

            var minHeight = int.Parse(Console.ReadLine());

            decimal allMeters = treesList
                .Select(n => n.Value.Sum())
                .ToList()
                .Sum();

            var logsCount = treesList
                .Select(n => n.Value.Count)
                .ToList()
                .Sum();

            decimal pricePerMeter = decimal.Round(allMeters / logsCount,2);

            var usedLogsMeters = (treesList[wantedType]
               .Where(n => n >= minHeight)
               .ToList()
               .Sum());

            var unusedLogsMeters = allMeters - usedLogsMeters;

            var unusedLogsPrice = decimal.Round((unusedLogsMeters * pricePerMeter / 4),2);

            var usedLogsPrice =decimal.Round (usedLogsMeters*pricePerMeter,2);

            var allPrice = usedLogsPrice + unusedLogsPrice;

            Console.WriteLine("Price per meter: ${0:f2}",pricePerMeter);
            Console.WriteLine("Used logs price: ${0:f2}",usedLogsPrice);
            Console.WriteLine("Unused logs price: ${0:f2}", unusedLogsPrice);
            Console.WriteLine("CottageScraper subtotal: ${0:f2}", allPrice);
        }

        private static void AddToTreesList(Dictionary<string, List<int>> treesList, string treeType, int treeHeight)
        {
            if (!treesList.ContainsKey(treeType))
            {
                treesList[treeType] = new List<int>();
            }
            treesList[treeType].Add(treeHeight);
        }
    }
}
