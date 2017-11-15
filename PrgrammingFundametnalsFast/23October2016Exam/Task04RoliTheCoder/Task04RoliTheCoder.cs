using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ID
{

    public string EventName { get; set; }

    public HashSet<string> Participants { get; set; }

    public ID(string eventName)
    {
        this.EventName = eventName;

        this.Participants = new HashSet<string>();
    }
}

class Task04RoliTheCoder
    {
        static void Main(string[] args)
        {

        Regex regFull = new Regex(@"(?<ID>\d+)\s+#(?<event>\S+)\s+(@\S+\s+)*");

        Regex regNames = new Regex(@"@\S+");

        Regex emptyReg = new Regex(@"(?<ID>\d+)\s+#(?<event>\S+)$");


        var dataBase = new Dictionary<string, ID>();

        while (true)
        {
            var input = Console.ReadLine();

            if (input == "Time for Code")
            {
                break;
            }
            if (emptyReg.IsMatch(input))
            {
                var IDQ = emptyReg.Match(input).Groups["ID"].Value;

                var eventNameQ = emptyReg.Match(input).Groups["event"].Value;

                if (!dataBase.ContainsKey(IDQ))
                {
                    dataBase[IDQ] = new ID(eventNameQ);
                }

                continue;
            }
            if (!regFull.IsMatch(input))
            {
                continue;
            }
            var ID = regFull.Match(input).Groups["ID"].Value;

            var eventName = regFull.Match(input).Groups["event"].Value;

            if (!dataBase.ContainsKey(ID))
            {
                dataBase[ID] = new ID(eventName);
            }
            else
            {
                if (dataBase[ID].EventName != eventName)
                {
                    continue;
                }
            }
            var participants = regNames.Matches(input).Cast<Match>().Select(n => n.Value).ToList();

            foreach (var human in participants)
            {
                dataBase[ID].Participants.Add(human);
            }
        }

        foreach (var pair in dataBase.OrderByDescending(n=>n.Value.Participants.Count).ThenBy(n=>n.Value.EventName))
        {
            Console.WriteLine($"{pair.Value.EventName} - {pair.Value.Participants.Count}");

            foreach (var human in pair.Value.Participants.OrderBy(n=>n))
            {
                Console.WriteLine(human);
            }
        }
    }
    }

