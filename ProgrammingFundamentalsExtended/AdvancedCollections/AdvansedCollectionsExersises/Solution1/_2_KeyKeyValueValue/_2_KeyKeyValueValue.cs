using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KeyKeyValueValue
{
    class _2_KeyKeyValueValue
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();

            var value = Console.ReadLine();

            var N = int.Parse(Console.ReadLine());

            var keyValuesList = new Dictionary<string, List<string>>();

            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

                var currentKey = input[0];

                var currentValues = input[1].Split(';');

                AddTheCurrentKeyAndValuesInTheList(keyValuesList, currentKey, currentValues);
            }

            PrintTheRightElementsInDictionary(keyValuesList, key, value);
        }

        private static void PrintTheRightElementsInDictionary(Dictionary<string, List<string>> keyValuesList, string key, string value)
        {
            foreach (var currentKey in keyValuesList.Keys)
            {
                
                if (currentKey.Contains(key))
                {
                    Console.WriteLine($"{currentKey}:");

                    foreach (var word in keyValuesList[currentKey])
                    {
                        if (word.Contains(value))
                        {
                            Console.WriteLine($"-{word}");
                        }
                    }
                }
            }
        }

        private static void AddTheCurrentKeyAndValuesInTheList(Dictionary<string, List<string>> keyValuesList
            , string currentKey, string[] currentValues)
        {
            if (!keyValuesList.ContainsKey(currentKey))
            {
                keyValuesList[currentKey] = new List<string>();
            }
            for (int i = 0; i < currentValues.Length; i++)
            {
                keyValuesList[currentKey].Add(currentValues[i]);
            }
        }
    }
}
