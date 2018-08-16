using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task05WordInPlural
{
    static void Main(string[] args)
    {

        string word = Console.ReadLine();

        if (word[word.Length - 1] == 'y')
        {
            word = ChangeTheWordWithYCase(word);
        }
        else if ((word[word.Length - 2] == 'c' && word[word.Length - 1] == 'h') || (word[word.Length - 2] == 's' && word[word.Length - 1] == 'h'))
        {
            word = ChangeTheWordByTwoLettersCase(word);
        }
        else if (word[word.Length - 1] == 'o' || word[word.Length - 1] == 's' || word[word.Length - 1] == 'x' || word[word.Length - 1] == 'z')
        {
            word = ChangeTheWordWitdS(word);
        }
        else
        {
            word = ChangeTheWordByCommonCase(word);
        }

        Console.WriteLine(word);
    }

    private static string ChangeTheWordWitdS(string word)
    {
        var builder = new StringBuilder(word);

        builder.Append("es");

        return builder.ToString();
    }

    private static string ChangeTheWordByCommonCase(string word)
    {
        var builder = new StringBuilder(word);

        builder.Append("s");

        return builder.ToString();
    }

    private static string ChangeTheWordByTwoLettersCase(string word)
    {
        var builder = new StringBuilder(word);

        builder.Append("es");

        return builder.ToString();
    }

    private static string ChangeTheWordWithYCase(string word)
    {
        var builder = new StringBuilder(word);

        builder.Remove(builder.ToString().LastIndexOf('y'), 1);

        builder.Append("ies");

        return builder.ToString();

    }
}

