using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task06ValidUsernames
{
    class Task06ValidUsernames
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Regex regex = new Regex(@"(?<=\b)[a-zA-Z]\w{2,24}(?=\b)");

            var matches = regex.Matches(input).Cast<Match>().Select(n => n.Value).ToList();

            var maxLength = -1;

            var maxIndex = -1;

            for (int i = 0; i < matches.Count-1; i++)
            {
                var currentLength = matches[i].Length + matches[i + 1].Length;

                if (currentLength>maxLength)
                {
                    maxLength = currentLength;

                    maxIndex = i;
                }
            }

            Console.WriteLine(matches[maxIndex]);
            Console.WriteLine(matches[maxIndex+1]);
        }
    }
}
