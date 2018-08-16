using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Task02WormIpsum
{
    static void Main(string[] args)
    {

        Regex reg = new Regex(@"^[A-Z]([^\.]+)*\.$");
        Regex wordReg = new Regex(@"[^\.\,\s]+");

        while (true)
        {
            var input = Console.ReadLine();

            if (input == "Worm Ipsum")
            {
                break;
            }
            if (!reg.IsMatch(input))
            {
                continue;
            }

            string output = ProcessTheSentence(input, wordReg);

            Console.WriteLine(output);
        }
    }

    private static string ProcessTheSentence(string input, Regex wordReg)
    {

        StringBuilder output = new StringBuilder();

        foreach (var word in wordReg.Matches(input).Cast<Match>().Select(n => n.Value).ToArray())
        {
            string newWord = ProceedTheWord(word);

            input = input.Replace(word, newWord);
        }

        return input;
    }

    private static string ProceedTheWord(string word)
    {
        var temp = new Dictionary<char, int>();


        foreach (var symbol in word)
        {
            if (!temp.ContainsKey(symbol))
            {
                temp[symbol] = 0;
            }
            temp[symbol] += 1;
        }

        char maxChar = temp.OrderByDescending(n => n.Value).Select(n => n.Key).First();

        if (temp[maxChar] == 1)
        {
            return word;
        }

        StringBuilder built = new StringBuilder();

        for (int i = 0; i < word.Length; i++)
        {
            built.Append(maxChar);
        }

        return built.ToString();
    }
}

