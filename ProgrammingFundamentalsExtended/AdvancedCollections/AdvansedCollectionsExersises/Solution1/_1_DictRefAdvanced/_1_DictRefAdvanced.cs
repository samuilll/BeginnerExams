using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _1_DictRefAdvanced
{
    static void Main(string[] args)
    {

        var line = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

        var dictionary = new Dictionary<string, List<int>>();

        while (line[0] !="end")
        {
            var key = line[0];

            var check = CheckForValue(line[1]);

            if (check)
            {
                var values = line[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                AddTheValues(dictionary, key, values);
            }
            else
            {
                var secondKey = line[1];

                FromSecondToFirstKey(dictionary, key, secondKey);
            }

           line =  Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
        }

        PrintTheResult(dictionary);
    }

    private static void PrintTheResult(Dictionary<string, List<int>> dictionary)
    {
        foreach (var key in dictionary.Keys)
        {
            Console.WriteLine($"{key} === {string.Join(", ",dictionary[key])}");
        }
    }

    private static void FromSecondToFirstKey(Dictionary<string, List<int>> dictionary, string key, string secondKey)
    {
        if (dictionary.ContainsKey(secondKey))
        {

            dictionary[key] = new List<int>(dictionary[secondKey]);

            //foreach (var value in dictionary[secondKey])
            //{
            //    dictionary[key].Add(value);
            //}
        }
    }

    private static void AddTheValues(Dictionary<string, List<int>> dictionary,
        string key, int[] values)
    {
        if (!dictionary.ContainsKey(key))
        {
            dictionary[key] = new List<int>();
        }

        foreach (var value in values)
        {
            dictionary[key].Add(value);
        }
    }

    private static bool CheckForValue(string v)
    {
        var list = v.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        return int.TryParse(list[0], out int number);
    }
}

