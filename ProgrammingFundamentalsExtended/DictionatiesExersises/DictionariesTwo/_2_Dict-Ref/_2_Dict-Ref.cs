using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .ToArray();

            var referenceDictionary = new Dictionary<string, int>();

            while (input[0]!="end")
            {
                FillTheDictionary(input, referenceDictionary);

                 input = Console.ReadLine()
                .Split()
                .ToArray();
            }

            foreach (var kvp in referenceDictionary)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }

        private static void FillTheDictionary(string[] input, Dictionary<string, int> referenceDictionary)
        {
            var check = int.TryParse(input[input.Length-1], out int value);

            var dictionaryKey = input[0];

            if (check)
            {
                referenceDictionary[dictionaryKey] = value;
            }
            else
            {
                var secondDictionaryKey = input[input.Length-1];

                if (referenceDictionary.ContainsKey(secondDictionaryKey))
                {
                    referenceDictionary[dictionaryKey] = referenceDictionary[secondDictionaryKey];
                }
            }
        }
    }
}
