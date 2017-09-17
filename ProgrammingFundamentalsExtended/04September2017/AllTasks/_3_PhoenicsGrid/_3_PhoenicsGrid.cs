using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _3_PhoenicsGrid
{
    static void Main(string[] args)
    {

        var line = Console.ReadLine();

        var isAPalindrom = string.Empty;

        while (line != "ReadMe")
        {
            isAPalindrom = CheckTheLine(line);

            Console.WriteLine(isAPalindrom);

            line = Console.ReadLine();
        }
    }

    private static string CheckTheLine(string line)
    {
        var trial = CreateAnArray(line);

        var holeLine = trial.Split(' ').ToList();

        foreach (var word in holeLine)
        {
            if (word.ToCharArray().Any(n => n == ' ') || word.ToCharArray().Any(n => n == '_') || word.ToCharArray().Any(n => n == '\t') || word.Length != 3)
            {
                return "NO";
            }
        }

        if (holeLine.Count == 1)
        {
            if (holeLine[0][0] == holeLine[0][2])
            {
                return "YES";
            }
            else
            {
                return "NO";
            }

        }


        var firstHalf = string.Join("", holeLine.Take(holeLine.Count / 2).ToList());

        holeLine.Reverse();

        var secondHalf = holeLine.Take(holeLine.Count / 2).ToList();

        secondHalf.Reverse();

        var secondHalfString = string.Join("", string.Join("", secondHalf).ToCharArray().Reverse());

        if (firstHalf.Equals(secondHalfString))
        {
            return "YES";
        }
        else
        {
            return "NO";
        }



    }

    private static string CreateAnArray(string line)
    {
        var word = new StringBuilder();

        for (int i = 0, j = 3; i < line.Length; i++)
        {

            if (i == j)
            {
                word.Append(' ');

                j += 4;
            }
            else
            {
                word.Append(line[i]);
            }
        }
        return word.ToString();
    }
}


