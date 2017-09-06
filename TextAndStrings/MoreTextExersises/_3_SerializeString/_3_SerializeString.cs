using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _3_SerializeString
{
    static void Main(string[] args)
    {
        var text = Console.ReadLine();

        var used = new StringBuilder(text);

        for (int i = 0; i < text.Length; i++)
        {
            var symbol = text[i];

            var currentOccurences = new StringBuilder();

            var index = -1;

            for (int j = 0; j < text.Length; j++)
            {
                if (used.ToString().Contains(text[i]) && text[j] == symbol)
                {
                    currentOccurences.Append(text.IndexOf(symbol, index + 1) + "/");

                    index = text.IndexOf(symbol, index + 1);
                }
            }

            if (currentOccurences.Length != 0)
            {
                Console.WriteLine($"{symbol}:{string.Join("/", currentOccurences.ToString().Trim('/'))}");
                //  Console.WriteLine("AAA");
            }

            used.Replace(symbol.ToString(), string.Empty);


        }
    }
}

