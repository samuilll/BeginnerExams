using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task09TeamworkProjects
{

    class Team
    {
        public string Name { get; set; }

        public List<string> Members { get; set; }

        public string Creator { get; set; }

        public Team(string creator, string name)
        {
            this.Name = name;

            this.Creator = creator;

            this.Members = new List<string>();

            Members.Add(creator);
        }
    }
    class Task09TeamworkProjects
    {
        static void Main(string[] args)
        {


            int howManyTeams = int.Parse(Console.ReadLine());

            Dictionary<string, Team> competitors = new Dictionary<string, Team>();

            string input;

            List<string> members = new List<string>();

            for (int i = 0; i < howManyTeams; i++)
            {
                input = Console.ReadLine();

                var split = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                string creatorName = split[0];

                string teamName = split[1];

                 if (competitors.Values.Any(n => n.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
               else if (competitors.ContainsKey(creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
               
                else
                {
                    competitors[creatorName] = new Team(creatorName, teamName);

                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");

                }

            }

            input = Console.ReadLine();

            while (input != "end of assignment")
            {
                var split = input.Split(new string[] { "->" }, StringSplitOptions.None).ToArray();

                string name = split[0];

                string teamName = split[1];

                if (!competitors.Values.Any(n => n.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                else if (competitors.Values.Any(n => n.Members.Contains(name)))
                {
                    Console.WriteLine($"Member {name} cannot join team {teamName}!");
                }

                else
                {
                    string leader = competitors.Where(n => n.Value.Name == teamName).Select(n => n.Key).First();

                    competitors[leader].Members.Add(name);
                }

                input = Console.ReadLine();
            }

            //  List<string> winners = competitors.Where(n=>n.Value.Members.Count>1).OrderByDescending(n=> n.Value.Members.Count).ThenBy(n=>n.Value.Name).Select(n=>n.Key).ToList();

            //   List<string> loosers = competitors.Where(n => n.Value.Members.Count == 1).OrderBy(n => n.Value.Name).Select(n => n.Key).ToList();

            foreach (var team in competitors
                .Where(n => n.Value.Members.Count > 1)
                .OrderByDescending(n => n.Value.Members.Count)
                .ThenBy(n => n.Value.Name))
            {
                Console.WriteLine($"{team.Value.Name}");

                Console.WriteLine($"- {team.Value.Creator}");

                foreach (var member in team.Value.Members
                    .Skip(1)
                    .OrderBy(n => n)
                    .ToList())
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine($"Teams to disband:");

            foreach (var disbandTeam in competitors.Where(n => n.Value.Members.Count <= 1).OrderBy(n => n.Value.Name))
            {
                Console.WriteLine($"{disbandTeam.Value.Name}");
            }

        }
    }
}
