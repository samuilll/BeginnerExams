using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _5_FlattenDictionary
{
    static void Main(string[] args)
    {

        var dictList = new Dictionary<string, Dictionary<string, string>>();

        var inputLine = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        while (inputLine[0] != "end")
        {


            if (inputLine[0] == "flatten")
            {
                var key = inputLine[1];

                FlattenTheKey(dictList, key);
            }
            else
            {
                var key = inputLine[0];

                var innerKey = inputLine[1];

                var innerValue = (inputLine[2]);

                FillTheDictionary(dictList, key, innerKey, innerValue);
            }

            inputLine = Console.ReadLine()
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        PrintTheDictionary(dictList);
    }

    private static void PrintTheDictionary(Dictionary<string, Dictionary<string, string>> dictList)
    {
        foreach (var pair in dictList.OrderByDescending(n => n.Key.Length))
        {
            Console.WriteLine($"{pair.Key}");

            var i = 0;

            foreach (var innerpair in pair.Value.Where(n => n.Value != string.Empty).OrderBy(n => n.Key.Length))
            {
                Console.WriteLine($"{++i}. {innerpair.Key} - {innerpair.Value}");
            }

            foreach (var innerpair in pair.Value.Where(n => n.Value == string.Empty))
            {
                Console.WriteLine($"{++i}. {innerpair.Key}");
            }
        }
    }

    private static void FillTheDictionary(Dictionary<string, Dictionary<string, string>> dictList, string key, string innerKey, string innerValue)
    {
        if (!dictList.ContainsKey(key))
        {
            dictList[key] = new Dictionary<string, string>();
        }
        dictList[key][innerKey] = innerValue;
    }

    private static void FlattenTheKey(Dictionary<string, Dictionary<string, string>> dictList, string key)
    {

        dictList[key] = dictList[key]
            .ToDictionary(n => n.Key + n.Value, n => string.Empty);
    }
}

