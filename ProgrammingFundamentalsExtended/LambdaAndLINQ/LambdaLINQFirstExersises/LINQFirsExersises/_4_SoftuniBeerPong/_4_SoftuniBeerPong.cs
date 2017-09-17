using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _4_SoftuniBeerPong
{
    static void Main(string[] args)
    {

        var inputLine = Console.ReadLine()
                   .Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var scoreList = new Dictionary<string, Dictionary<string, int>>();

        while (inputLine[0] != "stop")
        {
            var player = inputLine[0];

            var team = inputLine[1];

            var score = int.Parse(inputLine[2]);

            FillTheScoreList(scoreList, player, team, score);

            inputLine = Console.ReadLine()
                   .Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }


        PrintTheResult(scoreList);
    }

    private static void PrintTheResult(Dictionary<string, Dictionary<string, int>> scoreList)
    {
        scoreList = scoreList
            .Where(n => n.Value.Keys.Count == 3)
            .OrderByDescending(n => n.Value.Values.Sum()) 
            .ToDictionary(n => n.Key, n => n.Value);

        var i = 0;

        foreach (var pair in scoreList)
        {
            var team = pair.Key;
           
            Console.WriteLine($"{++i}. {team}; Players:");

            foreach (var playerScore in pair.Value.OrderByDescending(n=>n.Value))
            {
                Console.WriteLine($"###{playerScore.Key}: {playerScore.Value}");
            }
        }


    }

    private static void FillTheScoreList(Dictionary<string, Dictionary<string, int>> scoreList, string player, string team, int score)
    {
        if (!scoreList.ContainsKey(team))
        {
            scoreList[team] = new Dictionary<string, int>();

        }
        if (scoreList[team].Keys.Count < 3)
        {
            scoreList[team][player] = score;
        }
      
    }
}

