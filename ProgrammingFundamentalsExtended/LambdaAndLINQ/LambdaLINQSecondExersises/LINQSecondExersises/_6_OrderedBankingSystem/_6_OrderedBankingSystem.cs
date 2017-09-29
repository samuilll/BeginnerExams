using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _6_OrderedBankingSystem
{
    static void Main(string[] args)
    {
        var inputLine = Console.ReadLine()
                 .Split(new char[] { ' ', ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

        var register = new Dictionary<string, Dictionary<string, decimal>>();


        while (inputLine[0] != "end")
        {

            var bank = inputLine[0];

            var account = inputLine[1];

            var ballance = decimal.Parse(inputLine[2]);

            FillTheDictionary(register, bank, account, ballance);



            inputLine = Console.ReadLine()
                     .Split(new char[] { ' ', ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
        }

        //  PrintTheResult(register);

        register
            .ToList()
            .OrderByDescending(bankPair => bankPair.Value.Values.Sum())
            .ThenByDescending(bankPair => bankPair.Value.Values.Max())
            .ToList()
            .ForEach(bankPair => bankPair.Value
            .OrderByDescending(accountPair=>accountPair.Value)
            .ToList()
            .ForEach(accountPair => Console.WriteLine($"{accountPair.Key} -> {(accountPair.Value)} ({bankPair.Key})")
            ));
    }

    private static void PrintTheResult(Dictionary<string, Dictionary<string, decimal>> register)
    {
        foreach (var pair in register
            .OrderByDescending(n => n.Value.Values.Sum())
            .ThenByDescending(n => n.Value.Values.Max()))
        {
            var bank = pair.Key;

            foreach (var account in register[bank])
            {
                var ballance = account.Value;
                var name = account.Key;

                Console.WriteLine($"{name} -> {(ballance)} ({bank})");
            }
        }
    }

    private static void FillTheDictionary(Dictionary<string, Dictionary<string, decimal>> register, string bank, string account, decimal ballance)
    {
        if (!register.ContainsKey(bank))
        {
            register[bank] = new Dictionary<string, decimal>();
        }
        if (!register[bank].ContainsKey(account))
        {
            register[bank][account] = 0;
        }
        register[bank][account] += ballance;
    }
}

