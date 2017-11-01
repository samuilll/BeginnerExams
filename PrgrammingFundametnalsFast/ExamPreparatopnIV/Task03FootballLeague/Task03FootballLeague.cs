using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Team
{

    public long Points { get; set; }

    public long Goals { get; set; }

    public Team(long po, long go)
    {
        this.Points = po;

        this.Goals = go;
    }
}

class Task03FootballLeague
{
    static void Main(string[] args)
    {

        var key = Console.ReadLine();

        Regex resultReg = new Regex(@"(?<first>\d+):(?<second>\d+)\b");

        var dataBase = new Dictionary<string, Team>();


        while (true)
        {
            var input = Console.ReadLine();

            if (input == "final")
            {
                break;
            }

            RegisterTheMatchInformation( resultReg, dataBase, input,key);
        }

        Console.WriteLine("League standings:");

        var i = 0;

        foreach (var team in dataBase.OrderByDescending(n => n.Value.Points).ThenBy(n => n.Key))
        {
            Console.WriteLine($"{++i}. {team.Key} {team.Value.Points}");
        }

        i = 0;

        Console.WriteLine("Top 3 scored goals:");

        foreach (var team in dataBase.OrderByDescending(n => n.Value.Goals).ThenBy(n => n.Key).Take(3))
        {
            Console.WriteLine($"- {team.Key} -> {team.Value.Goals}");
        }
    }

    private static string GetSecond(string input, string key)
    {
        var index = input.IndexOf(key);

        var secondIndex = input.IndexOf(key, index + 1);

        var thirdIndex = input.IndexOf(key, secondIndex + 1);

        var lastIndex = input.IndexOf(key, thirdIndex + 1);

        var second = input.Substring(thirdIndex + key.Length, lastIndex - (thirdIndex + key.Length));

        return string.Join("", second.ToCharArray().Reverse());
    }

    private static string GetFirst(string input, string key)
    {
        var index = input.IndexOf(key);

        var secondIndex = input.IndexOf(key,index+1);

        var first = input.Substring(index + key.Length, secondIndex - (index + key.Length));

        return string.Join("",first.ToCharArray().Reverse());
    }

    private static void RegisterTheMatchInformation( Regex resultReg, Dictionary<string, Team> dataBase, string input,string key)
    {
        var firstTeam = GetFirst(input, key).ToUpper();

        var firstGoals = long.Parse(resultReg.Match(input).Groups["first"].Value);

        var secondTeam = GetSecond(input, key).ToUpper();

        var secondGoals = long.Parse(resultReg.Match(input).Groups["second"].Value);

        var firstIsWinner = firstGoals > secondGoals;

        var secondIsWinner = firstGoals < secondGoals;

        var draw = firstGoals == secondGoals;

        if (!dataBase.ContainsKey(firstTeam))
        {
            dataBase[firstTeam] = new Team(0, 0);
        }
        if (!dataBase.ContainsKey(secondTeam))
        {
            dataBase[secondTeam] = new Team(0, 0);
        }
        dataBase[firstTeam].Goals += firstGoals;
        dataBase[secondTeam].Goals += secondGoals;
        if (firstIsWinner)
        {
            dataBase[firstTeam].Points += 3;
        }
        else if (secondIsWinner)
        {
            dataBase[secondTeam].Points += 3;
        }
        else if (draw)
        {
            dataBase[firstTeam].Points += 1;
            dataBase[secondTeam].Points += 1;
        }
    }

}


