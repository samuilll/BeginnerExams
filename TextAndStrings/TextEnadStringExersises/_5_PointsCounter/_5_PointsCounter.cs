using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _5_PointsCounter
{
    static void Main(string[] args)
    {
        var inputLine = Console.ReadLine();

        var teamsList = new Dictionary<string, Dictionary<string, int>>();

        while (inputLine != "Result")
        {
            var inputLineSeparate = DeleteTheProhibitSigns(inputLine).Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var name = string.Empty;

            var team = string.Empty;

            var score = 0;

            if (inputLineSeparate[0].Any(n => char.IsLower(n)))
            {
                name = inputLineSeparate[0];

                team = inputLineSeparate[1];

                score = int.Parse(inputLineSeparate[2]);
            }

            else
            {
                name = inputLineSeparate[1];

                team = inputLineSeparate[0];

                score = int.Parse(inputLineSeparate[2]);
            }

            FillTheDataBase(teamsList, name, team, score);

            inputLine = Console.ReadLine();
        }

        PrintTheResult(teamsList);
    }

    private static void PrintTheResult(Dictionary<string, Dictionary<string, int>> teamsList)
    {
        foreach (var team in teamsList.OrderByDescending(n=>n.Value.Values.Sum()))
        {
            Console.WriteLine($"{team.Key} => {team.Value.Values.Sum()}");

            Console.WriteLine($"Most points scored by {team.Value.OrderByDescending(n=>n.Value).First().Key}");
        }    }

    private static void FillTheDataBase(Dictionary<string, Dictionary<string, int>> teamsList, string name, string team, int score)
    {
        if (!teamsList.ContainsKey(team))
        {
            teamsList[team] = new Dictionary<string, int>();
        }

        teamsList[team][name] = score;
    }

    private static string DeleteTheProhibitSigns(string inputLine)
    {
        var built = new StringBuilder(inputLine);

        built.Replace("%", string.Empty);
        built.Replace("@", string.Empty);
        built.Replace("$", string.Empty);
        built.Replace("*", string.Empty);

        return built.ToString();


    }
}

