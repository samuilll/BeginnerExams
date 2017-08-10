using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _3_MixedPhones
{
    static void Main(string[] args)
    {
        var phones = Console.ReadLine()
            .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        var sortedPhones = new SortedDictionary<string, decimal>();

        while (phones[0] != "Over")
        {
            FillTheDictionary(phones, sortedPhones);

            phones = Console.ReadLine()
            .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        }

        foreach (var kvp in sortedPhones)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }

    private static void FillTheDictionary(string[] phones, SortedDictionary<string, decimal> sortedPhones)
    {
        var check1 = decimal.TryParse(phones[1], out decimal number1);

        var check2 = decimal.TryParse(phones[0], out decimal number2);

        string name = "";

        var number = check1 == true ? number1 : number2;

        if (check1)
        {
             name = phones[0];
        }
        else
        {
             name = phones[1];
        }

        sortedPhones[name] = number;
    }
}

