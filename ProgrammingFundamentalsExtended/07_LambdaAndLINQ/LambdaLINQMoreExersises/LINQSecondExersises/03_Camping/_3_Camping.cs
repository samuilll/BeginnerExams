using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _3_Camping
{
    static void Main(string[] args)
    {
        var inputLine = Console.ReadLine()
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var campersRegister = new Dictionary<string, List<string>>();

        var accomdationRegister = new Dictionary<string, int>();



        while (inputLine[0] != "end")
        {

            var name = inputLine[0];

            var camper = inputLine[1];

            var days = int.Parse(inputLine[2]);

            FillTheDictionary(campersRegister, accomdationRegister, name, camper, days);


            inputLine = Console.ReadLine()
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        foreach (var pair in campersRegister.OrderByDescending(n=>n.Value.Count).ThenBy(n=>n.Key.Length))
        {
            Console.WriteLine($"{pair.Key}: {pair.Value.Count}");

            pair.Value
                .Select(n => "***" + n)
                .ToList()
                .ForEach(n=>Console.WriteLine(n));

            Console.WriteLine($"Total stay: {accomdationRegister[pair.Key]} nights");

        }
    }

    private static void FillTheDictionary(Dictionary<string, List<string>> campersRegister, Dictionary<string, int> accomdationRegister, string name, string camper, int days)
    {
        if (!campersRegister.ContainsKey(name))
        {
            campersRegister[name] = new List<string>();
        }
        campersRegister[name].Add(camper);
        if (!accomdationRegister.ContainsKey(name))
        {
            accomdationRegister[name] = 0;
        }
        accomdationRegister[name] += days;
    }
}

