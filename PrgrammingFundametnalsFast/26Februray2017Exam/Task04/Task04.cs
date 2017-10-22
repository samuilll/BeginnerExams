using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Soldier
    {

        public string Type { get; set; }

        public long Count { get; set; }

      
    }
    class Legion
    {
        public string Name { get; set; }

        public long LastActivity { get; set; }

        public List<Soldier> Soldiers { get; set; }
    }
    class Task04
    {
        static void Main(string[] args)
        {
            long howManyTimes = long.Parse(Console.ReadLine());

            Dictionary<string, Legion> legionList = new Dictionary<string, Legion>();


            for (long i = 0; i < howManyTimes; i++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ', '-', '>', '=', ':' }, StringSplitOptions.RemoveEmptyEntries);

                var currentActivity = long.Parse(input[0]);

                var currentLegion = input[1];

                var currentSoldierType = input[2];

                var currentSoldierCount = long.Parse(input[3]);

                if (!legionList.ContainsKey(currentLegion))
                {
                    var soldier = new Soldier { Type = currentSoldierType, Count = currentSoldierCount };

                    var legion = new Legion { Name = currentLegion, Soldiers = new List<Soldier>(), LastActivity = currentActivity };

                    legion.Soldiers.Add(soldier);

                    legionList[currentLegion] = legion;
                }
                else
                {
                    if (currentActivity>legionList[currentLegion].LastActivity)
                    {
                        legionList[currentLegion].LastActivity = currentActivity;
                    }
                    if (!legionList[currentLegion].Soldiers.Select(n => n.Type).Contains(currentSoldierType))
                    {
                        legionList[currentLegion].Soldiers.Add(new Soldier { Type = currentSoldierType, Count = currentSoldierCount});
                    }
                    else
                    {
                        legionList[currentLegion].Soldiers.Where(n => n.Type == currentSoldierType).Single().Count += currentSoldierCount;
                    }
                }

            }

            var inputSecond = Console.ReadLine().Split('\\');

            if (inputSecond.Length > 1)
            {
                var activity = long.Parse(inputSecond[0]);

                var soldierType = inputSecond[1];
                PrlongTheFirstCase(legionList, activity, soldierType);
            }
            else
            {
                var soldierType = inputSecond[0];
                PrlongTheSecondCase(legionList, soldierType);
            }
        }

        private static void PrlongTheSecondCase(Dictionary<string, Legion> legionList, string soldierType)
        {

            foreach (var legion in legionList.Values.OrderByDescending(n =>n.LastActivity))
            {
                foreach (var soldier in legion.Soldiers.Where(n => n.Type == soldierType))
                {
                    Console.WriteLine($"{legion.LastActivity} : {legion.Name}");
                }
            }
        }

        private static void PrlongTheFirstCase(Dictionary<string, Legion> legionList, long activity, string soldierType)
        {

            var output = new SortedDictionary<string,long>();

            foreach (var legion in legionList.Values.Where(n=>n.LastActivity<activity))
            {
                foreach (var soldier in legion.Soldiers.Where(n=>n.Type==soldierType))
                {
                    output[legion.Name] = soldier.Count;
                }
            }

            foreach (var pair in output.OrderByDescending(n=>n.Value))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
//  1 = BlackBeatles -> Soldier:2000