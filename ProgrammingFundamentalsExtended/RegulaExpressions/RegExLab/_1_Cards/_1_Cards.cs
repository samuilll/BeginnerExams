using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class _1_Cards
{
    static void Main(string[] args)
    {
        var pattern = @"([2-9JQKA]|(10))[S|H|D|C]";

        var regex = new Regex(pattern);

        var cards = new List<string>();

        var text = Console.ReadLine();

        var valids = regex.Matches(text);

        foreach (Match match in valids)
        {
            cards.Add(match.Value);
        }

        Console.WriteLine(string.Join(", ", cards));
    }
}

