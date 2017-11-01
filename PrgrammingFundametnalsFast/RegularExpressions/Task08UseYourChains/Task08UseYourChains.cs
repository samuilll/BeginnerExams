using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task08UseYourChains
{
    class Task08UseYourChains
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Regex regex = new Regex(@"(?<=<p>).*?(?=</p>)");

            var matches = regex.Matches(input).Cast<Match>().Select(n => n.Value).ToList();

            var sb = new StringBuilder();

            for (int i = 0; i < matches.Count; i++)
            {
                sb.Append(ImplementTheDecryption(matches[i]));
            }

            Console.WriteLine(string.Join(" ",sb.ToString().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries)));
        }

        private static string ImplementTheDecryption(string word)
        {
            string firstAlphabet = "abcdefghijklm";

            string secondAlphabet = "nopqrstuvwxyz";

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                var currentChar = word[i];

                if (!char.IsLower(currentChar) && !int.TryParse(currentChar.ToString(),out int num))
                {
                    result.Append(' ');
                }
               else if (currentChar>='a' && currentChar<='m')
                {
                  result.Append(secondAlphabet[firstAlphabet.IndexOf(currentChar)]);
                }
              else  if (currentChar >= 'n' && currentChar <= 'z')
                {
                    result.Append(firstAlphabet[secondAlphabet.IndexOf(currentChar)]);
                }
                else
                {
                    result.Append(currentChar);
                }
            }

            return result.ToString();
        }
    }
}
