using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task04WormsWorldParty
    {
        static void Main(string[] args)
        {

        var dataBase = new Dictionary<string, Dictionary<string, long>>();

        while (true)
        {
            var input = Console.ReadLine()
                .Split(new char[] { '-', '>' },StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (input[0]== "quit")
            {
                break;
            }
            var teamName = input[1].Trim();

            var playerName = input[0].Trim();

            var score = long.Parse(input[2]);

            if (ThereIsSuchAPlayer(dataBase,playerName))
            {
               // var check = dataBase.Values.Select(n => n.Keys.Where(k => k == playerName).First()).First();
                continue;
            }
            if (!dataBase.ContainsKey(teamName))
            {
                dataBase[teamName] = new Dictionary<string, long>();
            }
            dataBase[teamName][playerName] = score;
        }

        var i = 0;
        foreach (var teamPair in dataBase.OrderByDescending(n=>n.Value.Values.Sum()).ThenByDescending(n=> n.Value.Values.Sum()/n.Value.Keys.Count))
        {
            Console.WriteLine($"{++i}. Team: {teamPair.Key} - {teamPair.Value.Values.Sum()}");

            foreach (var worm in teamPair.Value.OrderByDescending(n=>n.Value))
            {
                Console.WriteLine($"###{worm.Key} : {worm.Value}");
            }
        }

        }

    private static bool ThereIsSuchAPlayer(Dictionary<string, Dictionary<string, long>> dataBase,string player)
    {
        foreach ( var teamPair in dataBase)
        {
            foreach (var playerPair in teamPair.Value)
            {
                if (playerPair.Key==player)
                {
                    return true;
                }
            }
        }
 
        return false;
    }
}

