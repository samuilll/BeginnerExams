using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _01_OddOccurences
{
    static void Main(string[] args)
    {
        var words = Console.ReadLine()
            .ToLower()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        var oddNumbers = new Dictionary<string, int>();

        var outputList = new List<string>();

        for (int i = 0; i < words.Count; i++)
        {
            if (!oddNumbers.ContainsKey(words[i]))
            {
                oddNumbers.Add(words[i], 1);
            }

            else
            {
                oddNumbers[words[i]] += 1;
            }

        }

        //foreach (var kvp in oddNumbers)
        //{
        //    var key = kvp.Key;

        //    var number = kvp.Value;

        //    Console.WriteLine($"{key} -> {number}");
        //}

        foreach (var kvp in oddNumbers)
        {
            if (kvp.Value % 2 != 0)
            {
                outputList.Add(kvp.Key);
            }
        }

        Console.WriteLine(string.Join(", ",outputList));
    }
}

