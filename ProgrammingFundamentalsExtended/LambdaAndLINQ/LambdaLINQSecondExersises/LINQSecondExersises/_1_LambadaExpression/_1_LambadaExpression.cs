using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _1_LambadaExpression
{
    static void Main(string[] args)
    {
        var inputLine = Console.ReadLine()
                  .Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

        var register = new Dictionary<string, string>();


        while (inputLine[0] != "lambada")
        {
            if (inputLine[0] != "dance")
            {
                var selector = inputLine[0];

                var objectProperty = inputLine[1];

                FillTheDictionary(register, selector, objectProperty);
            }
            else
            {
                DanceTheRegister(register);
            }

            inputLine = Console.ReadLine()
                     .Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
        }

        PrintTheResult(register);
    }

    private static void DanceTheRegister(Dictionary<string, string> register)
    {
        var keysList = register.Select(n => n.Key).ToList();

        for (int i = 0; i < keysList.Count; i++)
        {
            var key = keysList[i];

            var splitValue = register[key].Split('.').ToList();

            var selectorObject = splitValue[0];

            var property = splitValue[splitValue.Count - 1];

            splitValue.Insert(splitValue.Count - 1, selectorObject);

            register[key] =string.Join(".",splitValue);
        }
    }

    private static void PrintTheResult(Dictionary<string, string> register)
    {
        foreach (var pair in register)
        {
            Console.WriteLine($"{pair.Key} => {pair.Value}");
        }
    }

    private static void FillTheDictionary(Dictionary<string, string> register, string selector, string objectProperty)
    {
        register[selector] = objectProperty;
    }
}

