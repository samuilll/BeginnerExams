using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _6_StateLess
{
    static void Main(string[] args)
    {

        var sentence = Console.ReadLine();

        var fiction = Console.ReadLine();

        var empty = "(void)";

        while (true)
        {
            sentence = CollapseTheSentence(sentence, fiction);

            Console.WriteLine((sentence!=string.Empty)? sentence:empty);

            sentence = Console.ReadLine();

            if (sentence == "collapse")
            {
                break;
            }

            fiction = Console.ReadLine();
        }
    }

    private static string CollapseTheSentence(string sentence, string fiction)
    {
        var sentenceBuilder = new StringBuilder(sentence);

        var fictionBuilder = new StringBuilder(fiction);

        while (fictionBuilder.Length != 0)
        {
            sentenceBuilder.Replace(fictionBuilder.ToString(), string.Empty);

            if (fictionBuilder.Length>1)
            {
                fictionBuilder.Remove(fictionBuilder.Length - 1, 1);
                fictionBuilder.Remove(0, 1);
            }
            else
            {
                fictionBuilder.Remove(0, 1);
            }
        }

        return sentenceBuilder.ToString().Trim();
    }
}

