using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class _5_SoftuniMessages
{
    static void Main(string[] args)
    {
        var text = Console.ReadLine();

        var number = int.Parse(Console.ReadLine());

        while (true)
        {
            var regex = new Regex(@"(?<digits1>\d+)(?<word>[A-Za-z]+)(?<digits2>[^A-Za-z]+)$");

            var match = regex.Match(text);

            if (match.Success && match.Groups["word"].Value.Length==number)
            {
                var endDigitSearch = IsThereADigitInTheEnd(match.Groups["digits2"].Value);

                if (endDigitSearch)
                {
                    var decryptedWord = BuiltAWord(match,number,text);

                    Console.WriteLine("{0} = {1}",match.Groups["word"].Value,decryptedWord);
                }
            }

             text = Console.ReadLine();

            if (text=="Decrypt!")
            {
                break;
            }

             number = int.Parse(Console.ReadLine());
        }

    }

    private static string BuiltAWord(Match match, int number, string text)
    {
        var newWordBuilder = new StringBuilder();

        var digitBuilder = new StringBuilder();

        var originalWord = match.Groups["word"].Value;
            
        foreach (var digit in match.Groups["digits1"].Value)
        {
            if (int.Parse(digit.ToString())<number)
            {
                digitBuilder.Append(digit);
            }
        }

        foreach (var symbol in match.Groups["digits2"].Value)
        {
            if (int.TryParse(symbol.ToString(),out int num))
            {
                if (num<number)
                {
                    digitBuilder.Append(symbol);
                }
            }
        }

        foreach (var digit in digitBuilder.ToString())
        {
            newWordBuilder.Append(originalWord[int.Parse(digit.ToString())]);
        }

        return newWordBuilder.ToString();
    }

    private static bool IsThereADigitInTheEnd(string value)
    {
        var check = false;

        for (int i = 0; i < value.Length; i++)
        {
            if (int.TryParse(value[i].ToString(), out int p))
            {
                check = true;

                break;
            }
        }

        return check;
    }
}

