using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class _2_MatchPhoneNumber
{
    static void Main(string[] args)
    {

        var text = Console.ReadLine();

        var pattern = @"(?<=\s|)\+359([ -])2\1\d{3}\1\d{4}\b";

        var regex = new Regex(pattern);

        var matches = regex.Matches(text);

        var validNumbers = new List<string>();

        foreach (Match number in matches)
        {
            validNumbers.Add(number.Value);
        }

        Console.WriteLine(string.Join(", ", validNumbers));
    }
}

