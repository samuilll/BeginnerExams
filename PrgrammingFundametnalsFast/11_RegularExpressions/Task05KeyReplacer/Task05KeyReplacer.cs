using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task05KeyReplacer
{
    class Task05KeyReplacer
    {
        static void Main(string[] args)
        {
            string keyString = Console.ReadLine();

            Regex regex = new Regex(@"(?<start>[a-zA-Z]+)[|<\\].+[<|\\](?<end>[a-zA-Z]+)$");

            string startKey = regex.Match(keyString).Groups["start"].Value;

            string endKey = regex.Match(keyString).Groups["end"].Value;

            Regex ouputReg = new Regex($"(?<={startKey}).*?(?={endKey})");

            string text = Console.ReadLine();

            var matches = ouputReg.Matches(text).Cast<Match>().Select(n => n.Value).Where(n=>n!=string.Empty).ToList();

            if (matches.Count>0)
            {
                Console.WriteLine(string.Join("", matches));
            }
            else
            {
                Console.WriteLine("Empty result");
            }

        }
    }
}
