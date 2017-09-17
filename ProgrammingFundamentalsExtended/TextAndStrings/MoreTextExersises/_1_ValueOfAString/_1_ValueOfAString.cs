using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _1_ValueOfAString
{
    static void Main(string[] args)
    {
        var text = Console.ReadLine();

        var request = Console.ReadLine();

        var sum = 0;

        for (int i = 0; i < text.Length; i++)
        {
            switch (request)
            {
                case "LOWERCASE": { sum = LowerSum(text); break; }

                case "UPPERCASE": { sum = UpperSum(text); break; }
            }
        }

        Console.WriteLine($"The total sum is: {sum}");

    }

    private static int UpperSum(string text)
    {
        var sum = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
            {
                sum += (int)(text[i]);
            }
        }

        return sum;
    }

    private static int LowerSum(string text)
    {
        var sum = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLower(text[i]))
            {
                sum += (int)(text[i]);
            }
        }

        return sum;
    }
}

