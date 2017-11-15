using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Task03
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        Regex regHolder = new Regex(@"(?<border>[A-Za-z]+)(?<holder>.+)\1");

        var holderMatches = regHolder
            .Matches(input)
            .Cast<Match>()
            .Select(n => n.Groups["holder"].Value)
            .ToList();

        var fullMatches = regHolder
            .Matches(input)
            .Cast<Match>()
            .Select(n => n.Value)
            .ToList();

        var values = Console.ReadLine()
            .Split(new char[] { '}','{' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        for (int i = 0; i < holderMatches.Count; i++)
        {
            var oldValue = fullMatches[i]; 

            var newValue = fullMatches[i].Replace(holderMatches[i],values[i]);

            input = input.Replace(oldValue,newValue);
        }

        Console.WriteLine(input);
    }
}

