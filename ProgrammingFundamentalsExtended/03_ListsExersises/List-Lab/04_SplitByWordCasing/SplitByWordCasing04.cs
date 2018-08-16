using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing04
{
    class SplitByWordCasing04
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var lower = new List<string>();
            var upper = new List<string>();
            var mixed = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                string check = CheckTheWord(words[i]);

                switch (check)
                {
                    case "lower":lower.Add(words[i]); break;
                    case "upper": upper.Add(words[i]); break;
                    case "mixed": mixed.Add(words[i]); break;
                }

                
            }

            Console.WriteLine("Lower-case: {0}",string.Join(", ", lower));

            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixed));

            Console.WriteLine("Upper-case: {0}", string.Join(", ", upper));
        }

        private static string CheckTheWord(string word)
        {
            List<int> check = new List<int>();

            string type = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLower(word[i]))
                {
                    check.Add(1);
                }
                else if (char.IsUpper(word[i]))

                {
                    check.Add(2);
                }
                else
                    check.Add(3);


            }

            if (!check.Contains(2) && !check.Contains(3))
            {
                type = "lower";
            }

            if (!check.Contains(1) && !check.Contains(3))
            {
                type = "upper";
            }

            if ((check.Contains(1) && check.Contains(2)) || check.Contains(3))
            {
                type = "mixed";
            }
            return type;
        }
    }
}
