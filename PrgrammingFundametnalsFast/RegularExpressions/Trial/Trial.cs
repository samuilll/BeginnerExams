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

            //byte[] inputBuffer = new byte[4096];

            //Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);

            //Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

            string input = Console.ReadLine();

            Regex regex = new Regex(@"(?<=<p>).*?(?=</p>)");

            var matches = regex.Matches(input).Cast<Match>().Select(n => n.Value).ToList();

            var sb = new StringBuilder();

            for (int i = 0; i < matches.Count; i++)
            {

                sb.Append(ImplementTheDecryption(matches[i]));
            }


            Console.WriteLine(sb.ToString());
        }

        private static string ImplementTheDecryption(string word)
        {
            //  string firstAlphabet = "abcdefghijklm";

            //   string secondAlphabet = "nopqrstuvwxyz";

            word = Regex.Replace(word, "[^a-z0-9]", " ");

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                var currentChar = word[i];

                if (char.IsLower(currentChar))
                {
                    if (currentChar < 110)
                    {
                        result.Append((char)(currentChar + 13));
                    }
                    else if (currentChar >= 110)
                    {
                        result.Append((char)(currentChar - 13));
                    }

                }
                else
                {
                    result.Append(currentChar);
                }
            }


            return Regex.Replace(result.ToString(), "\\s+", " ");
        }
    }
}
