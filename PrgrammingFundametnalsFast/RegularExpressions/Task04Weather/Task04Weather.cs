using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task04Weather
{
    class Task04Weather
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Regex regex = new Regex(@"(?<town>[A-Z]{2})(?<temp>\d+.\d+)(?<type>[a-zA-Z]+)(?=\|)");

            var data = new Dictionary<string, Dictionary<string, double>>();

            while (input!="end")
            {
                var isMatched = regex.IsMatch(input);

                if (isMatched)
                {
                    var match = regex.Match(input);

                    var town = match.Groups["town"].Value;

                    var temp = double.Parse(match.Groups["temp"].Value);

                    var type = match.Groups["type"].Value;

                    data[town] = new Dictionary<string, double>();

                    data[town][type] = temp;
                }

                input = Console.ReadLine();
            }

            foreach (var town in data.OrderBy(n=>n.Value.Values.Sum()))
            {
                Console.WriteLine($"{town.Key} => {town.Value.Values.First():f2} => {town.Value.Keys.First()}");
            }
        }
    }
}
