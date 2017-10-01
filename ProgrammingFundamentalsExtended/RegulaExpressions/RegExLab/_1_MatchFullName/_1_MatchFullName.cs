using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class _1_MatchFullName
{
    static void Main(string[] args)
    {

        var text = Console.ReadLine();

        var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

        var regex = new Regex(pattern);

        var names = regex.Matches(text);

        var result = new List<string>();

        foreach (Match name in names)
        {
            result.Add(name.Value.Trim());
        }

        Console.WriteLine(string.Join(" ",result));
    }
}

