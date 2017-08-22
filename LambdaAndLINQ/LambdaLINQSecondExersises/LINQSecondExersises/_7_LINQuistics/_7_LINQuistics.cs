using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _7_LINQuistics
{
    static void Main(string[] args)
    {
        var inputLine = Console.ReadLine()
                .Split(new char[] { ')', '(', '.', }, StringSplitOptions.RemoveEmptyEntries);

        var register = new Dictionary<string, HashSet<string>>();


        while (inputLine[0] != "exit")
        {
            var check = int.TryParse(inputLine[0], out int number);
            if (inputLine.Length > 1)
            {
                var collection = inputLine[0];

                var methods = inputLine
                    .Skip(1)
                    .ToList();

                FillTheRegister(register, collection, methods);
            }

            else if (check)
            {
                DigitFunction(register, number);
            }

            else if (register.ContainsKey(inputLine[0]))
            {
                var collection = inputLine[0];

                PrintTheMethodsInThisCollection(register, collection);
            }

            inputLine = Console.ReadLine()
                     .Split(new char[] { ')', '(', '.', }, StringSplitOptions.RemoveEmptyEntries);
        }

        inputLine = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var method = inputLine[0];

        var selectoin = inputLine[1];

        if (selectoin == "collection")
        {
            PrintOnlyTheCollections(register, selectoin, method);
        }
        else
        {
            PrintAll(register, selectoin, method);
        }

    }

    private static void PrintAll(Dictionary<string, HashSet<string>> register, string selectoin, string method)
    {
        foreach (var pair in register
            .OrderByDescending(n => n.Value.Count)
            .ThenByDescending(n => n.Value
                 .OrderBy(word => word.Length)
                 .First()))
        {
            var collection = pair.Key;

            if (register[collection].Contains(method))
            {
                Console.WriteLine(collection);

                foreach (var met in register[collection].OrderByDescending(n => n.Length))
                {
                    Console.WriteLine($"* {met}");
                }
            }
        }
    }

    private static void PrintOnlyTheCollections(Dictionary<string, HashSet<string>> register, string selectoin, string method)
    {
        register
                    .Where(n => n.Value.Contains(method))
                    .OrderByDescending(n => n.Value.Count)
                    .ThenByDescending(n => n.Value.OrderBy(word => word.Length).First())
                    .ToList()
                    .ForEach(n => Console.WriteLine($"{n.Key}"));


    }
    private static void PrintTheMethodsInThisCollection(Dictionary<string, HashSet<string>> register, string collection)
    {
        register[collection]
                    .OrderByDescending(n => n.Length)
                    .ThenByDescending(n => n.Distinct().ToArray().Length)
                    .ToList()
                    .ForEach(n => Console.WriteLine($"* {n}"));
    }
    private static void DigitFunction(Dictionary<string, HashSet<string>> register, int number)
    {
        register
                            .OrderByDescending(n => n.Value.Count)
                            .Take(1)
                            .ToList()
                            .ForEach(n => n.Value.OrderBy(method => method.Length)
                            .Take(number)
                            .ToList()
                            .ForEach(method => Console.WriteLine($"* {method}")));
    }

    private static void FillTheRegister(Dictionary<string, HashSet<string>> register, string collection, List<string> methods)
    {
        if (!register.ContainsKey(collection))
        {
            register[collection] = new HashSet<string>();
        }
        foreach (var method in methods)
        {
            register[collection].Add(method);
        }
    }
}

