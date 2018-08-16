using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4_MatchDates
{
    class _4_MatchDates
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var pattern = @"\b(?<day>\d{2})([/|\-|.])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            var regex = new Regex(pattern);

            var matches = regex.Matches(text);

            var validDates = new List<string>();

            foreach (Match date in matches)
            {
                Console.WriteLine($"Day: {date.Groups["day"].Value}, Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value} ");            }

            Console.WriteLine(string.Join(", ", validDates));
        }
    }
}
