using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _4_Websites
{
    static void Main(string[] args)
    {
        var inputLine = Console.ReadLine();

        var sites = new List<Website>();

        while (inputLine != "end")
        {
            var currentSite = Website.Parse(inputLine);

            sites.Add(currentSite);

            inputLine = Console.ReadLine();
        }

        PrintTheResult(sites);
    }

    private static void PrintTheResult(List<Website> sites)
    {
        foreach (var path in sites)
        {
            if (path.Queries!=null)
            {
                Console.WriteLine($"https://www.{path.Host}.{path.Domain}/query?=[{string.Join("]&[", path.Queries)}]");
            }
            else
            {
                Console.WriteLine($"https://www.{path.Host}.{path.Domain}");

            }
        }
    }
}

