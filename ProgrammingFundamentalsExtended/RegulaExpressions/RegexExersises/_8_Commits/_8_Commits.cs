using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class Commit
{

    public string Hash { get; set; }

    public string Message { get; set; }

    public int Additions { get; set; }

    public int Deletions { get; set; }

    public Commit(string hash, string message, int additions, int deletions)
    {
        this.Hash = hash;
        this.Message = message;
        this.Additions = additions;
        this.Deletions = deletions;
    }


}

class _8_Commits
{
    static void Main(string[] args)
    {

        var input = Console.ReadLine();

        var List = new Dictionary<string, Dictionary<string, List<Commit>>>();

        var regex = new Regex(@"https:\/\/github.com\/(?<user>[\w+\-]+)\/(?<repo>[A-Za-z\-_]+)\/commit\/(?<hash>[A-Fa-f\d]{40}),(?<message>[^\n]+?),(?<additions>\d+?),(?<deletions>\d+)\b");

        while (input != "git push")
        {

            if (regex.IsMatch(input))
            {
                Match match = regex.Match(input);

                var userName = match.Groups["user"].Value;

                var repo = match.Groups["repo"].Value;

                var hash = match.Groups["hash"].Value;

                var message = match.Groups["message"].Value;

                var addiotions = int.Parse(match.Groups["additions"].Value);

                var deletions = int.Parse(match.Groups["deletions"].Value);

                var currentCommit = new Commit(hash, message, addiotions, deletions);

                FullTheList(List, currentCommit, userName, repo);
            }

            input = Console.ReadLine();
        }

        PrintTheResult(List);
    }

    private static void PrintTheResult(Dictionary<string, Dictionary<string, List<Commit>>> list)
    {
        foreach (var userPair in list.OrderBy(n=>n.Key))
        {
            Console.WriteLine($"{userPair.Key}:");

            foreach (var repoPair in userPair.Value.OrderBy(n=>n.Key))
            {
                Console.WriteLine($"  {repoPair.Key}:");

                foreach (var commit in repoPair.Value)
                {
                    Console.WriteLine($"    commit {commit.Hash}: {commit.Message} ({commit.Additions} additions, {commit.Deletions} deletions)");
                }

                var additionsTotal = repoPair.Value.Select(n => n.Additions).Sum();

                var deletionsTotal = repoPair.Value.Select(n => n.Deletions).Sum();

                Console.WriteLine($"    Total: {additionsTotal} additions, {deletionsTotal} deletions");
            }

        }
    }

    private static void FullTheList(Dictionary<string, Dictionary<string, List<Commit>>> list, Commit currentCommit, string userName, string repo)
    {
        if (!list.ContainsKey(userName))
        {
            list[userName] = new Dictionary<string, List<Commit>>();
        }

        if (!list[userName].ContainsKey(repo))
        {
            list[userName][repo] = new List<Commit>();
        }

        list[userName][repo].Add(currentCommit);


    }
}

