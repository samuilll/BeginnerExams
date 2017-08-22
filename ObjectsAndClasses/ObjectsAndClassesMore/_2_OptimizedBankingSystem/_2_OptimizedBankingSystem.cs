using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _2_OptimizedBankingSystem
{
    static void Main(string[] args)
    {

        var inputLine = Console.ReadLine();

        var AccountsList = new List<BankAccount>();

        while (inputLine != "end")
        {
            var currentAccount = BankAccount.Parse(inputLine);

            var check = AccountsList.Any(n => n.Name == currentAccount.Name && n.Bank == currentAccount.Bank);

            if (!check)
            {
                AccountsList.Add(currentAccount);
            }
            else
            {
                var index = AccountsList.IndexOf(AccountsList.Single(n => n.Name == currentAccount.Name && n.Bank == currentAccount.Bank));

                AccountsList[index].Ballance += currentAccount.Ballance;
            }


            inputLine = Console.ReadLine();
        }

        AccountsList = AccountsList
            .OrderByDescending(n => n.Ballance)
            .ThenBy(n => n.Bank.Length)
            .ToList();

        foreach (var account in AccountsList)
        {
            Console.WriteLine($"{account.Name} -> {account.Ballance} ({account.Bank})");
        }

    }
}

