using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task02ExtractSentenceByKeyword
{
    class Task02ExtractSentenceByKeyword
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();

            string text = Console.ReadLine();

            Regex sentenceReg = new Regex(@"(?<=\b|\!|\?|\.)[^! \.\?][^\.\!\?]+?(?=\!|\?|\.)");

            Regex wordReg = new Regex($"(?<=\\b){word}(?=\\b)");

            var matches = sentenceReg.Matches(text).Cast<Match>().Select(n => n.Value).ToList();

            foreach (var sentence in matches)
            {
                if (wordReg.IsMatch(sentence))
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}
