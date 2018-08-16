using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_MatchHexadecimalNumbers
{
    class _3_MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var pattern = @"\b(?:0x)?[0-9A-F]+\b";

            var regex = new Regex(pattern);

            var matches = regex.Matches(text);

            var validNumbers = new List<string>();

            foreach (Match number in matches)
            {
                validNumbers.Add(number.Value);
            }

            Console.WriteLine(string.Join(" ", validNumbers));
        }
    }
}
