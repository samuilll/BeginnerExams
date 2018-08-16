using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5_MatchNumbers
{
    class _5_MatchNumbers
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

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
