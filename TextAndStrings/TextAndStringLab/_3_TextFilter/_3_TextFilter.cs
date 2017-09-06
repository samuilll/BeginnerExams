using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_TextFilter
{
    class _3_TextFilter
    {
        static void Main(string[] args)
        {

            var badWords = Console.ReadLine()
                .Split(new[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var text = Console.ReadLine();

            foreach (var badWord in badWords)
            {
                if (text.Contains(badWord))
                {
                   text = text.Replace(badWord, new string('*', badWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
