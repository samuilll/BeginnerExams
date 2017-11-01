using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task07QueryMess
{
    class Task07QueryMess
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Regex regex = new Regex(@"(?<=(\b|&))(?<key>[^&\?]+?)=(?<value>[^&\?]+?)(?=(&|$|\s))");

            while (input!="END")
            {
                var data = new Dictionary<string, List<string>>();

                var matches = regex.Matches(input).Cast<Match>().Select(n => n.Value).ToList();

                foreach (var pair in matches)
                {
                    string key = regex.Match(pair).Groups["key"].Value;

                    key = Regex.Replace(key, @"(%20)|(\+)", " ").Trim();

                    string value = regex.Match(pair).Groups["value"].Value;

                    value = Regex.Replace(value, @"(%20)|(\+)", " ").Trim();

                    key = Regex.Replace(key, @"\s+", " ").Trim();

                    value = Regex.Replace(value, @"\s+", " ").Trim();


                    if (!data.ContainsKey(key))
                    {
                        data[key] = new List<string>();
                    }

                    data[key].Add(value);
                }

                foreach (var pair in data)
                {
                    Console.Write($"{pair.Key}=[{string.Join(", ",pair.Value)}]");
                }

                Console.WriteLine();

                input = Console.ReadLine();
            }
        }
    }
}
