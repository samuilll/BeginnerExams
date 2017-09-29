using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BankAccount
{
    public string Name { get; set; }

    public string Bank { get; set; }

    public decimal Ballance { get; set; }

    public static BankAccount Parse(string inputLine)
    {
        var account = new BankAccount();

        var separateInput = inputLine
         .Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries)
         .ToList();

        account.Bank = separateInput[0];

        account.Name = separateInput[1];

        account.Ballance = decimal.Parse(separateInput[2]);

        return account;
    }

    //public bool Contains(string name, string bank)
    //{
    //    var account = new BankAccount();

    //    if (account.Name == name && account.Bank == bank)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
}

