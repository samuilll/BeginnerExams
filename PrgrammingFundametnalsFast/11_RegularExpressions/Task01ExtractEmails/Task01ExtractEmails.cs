using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task01ExtractEmails
{
    class Task01ExtractEmails
    {
        static void Main(string[] args)
        {

            Regex reg = new Regex(@"(?<=\s)[a-zA-Z0-9][\w\._-]*@[a-zA-Z-]+(\.[a-zA-Z][a-zA-Z-]*[a-zA-Z])+");

            var text = Console.ReadLine();

            var matches = reg.Matches(text).Cast<Match>().Select(n => n.Value).ToList();

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
