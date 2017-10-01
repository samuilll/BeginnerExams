using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class _2_WordEncounter
{
    static void Main(string[] args)
    {

        var filter = Console.ReadLine();

        var sentence = Console.ReadLine();

        var sentencePattern = @"^[A-Z].*[.!?]$";

        var wordPattern = @"(\w+)";

        var sentenceRegex = new Regex(sentencePattern);

        var wordRegex = new Regex(wordPattern);

        var goodWords = new List<string>();

        while (sentence != "end")
        {
            var sentenceIsValid = sentenceRegex.IsMatch(sentence);

            if (sentenceIsValid)
            {
                var words = wordRegex.Matches(sentence).Cast<Match>().Select(n => n.Value).ToList();

                foreach (var word in words)
                {
                    var wordIsValid = IsTheWordValid(word, filter);

                    if (wordIsValid)
                    {
                        goodWords.Add(word);
                    }
                }
            }

            sentence = Console.ReadLine();
        }

        Console.WriteLine(string.Join(", ", goodWords));
    }

    private static bool IsTheWordValid(string word, string filter)
    {
        var symbol = filter[0];

        var searchedNumber = int.Parse(filter[1].ToString());

        var counter = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i]==symbol)
            {
                counter++;
            }
        }

        if (counter>=searchedNumber)
        {
            return true;
        }
        else
        {
            return false;
        }    
    }
}

