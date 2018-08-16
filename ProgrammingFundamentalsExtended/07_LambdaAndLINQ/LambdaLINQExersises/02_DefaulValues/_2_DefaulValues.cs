using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _2_DefaulValues
{
    static void Main(string[] args)
    {

        var inputLine = Console.ReadLine()
            .Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var storage = new Dictionary<string, string>();

        while (inputLine[0] != "end")
        {
            var key = inputLine[0];

            var value = inputLine[1];

            storage[key] = value;

            inputLine = Console.ReadLine()
            .Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        }

        var defaultValue = Console.ReadLine();

        storage.
            Where(n => n.Value != "null")
            .OrderByDescending(n => n.Value.Length)
            .ToList()
            .ForEach(n => Console.WriteLine($"{n.Key} <-> {n.Value}"));

        storage
               .Where(n => n.Value == "null")
               .Select(n=>n.Key + " <-> " +defaultValue)
               .ToList()
               .ForEach(Console.WriteLine);





    }
}

