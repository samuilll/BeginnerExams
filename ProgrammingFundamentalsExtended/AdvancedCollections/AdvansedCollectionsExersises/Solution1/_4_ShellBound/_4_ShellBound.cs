using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _4_ShellBound
{
    static void Main(string[] args)
    {

        var shells = new Dictionary<string, HashSet<int>>();

        var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        while (line[0] != "Aggregate")
        {
            var region = line[0];

            var size = int.Parse(line[1]);

            AddTheRegionAndSize(shells, region, size);

            line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        }

        foreach (var region in shells.Keys)
        {
            var bigSize = takeTheSizeOfMergedRegion(shells, region);

            Console.WriteLine($"{region} -> {string.Join(", ",shells[region])} ({bigSize})");
        }
    }

    private static object takeTheSizeOfMergedRegion(Dictionary<string, HashSet<int>> shells, string region)
    {
        return  Math.Ceiling(shells[region].Sum() - shells[region].Average());
    }

    private static void AddTheRegionAndSize(Dictionary<string, HashSet<int>> shells, string region, int size)
    {
        if (!shells.ContainsKey(region))
        {
            shells[region] = new HashSet<int>();
        }

        shells[region].Add(size);
    }
}

