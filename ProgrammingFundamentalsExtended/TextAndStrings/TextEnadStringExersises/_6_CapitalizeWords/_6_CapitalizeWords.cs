using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_CapitalizeWords
{
    class _6_CapitalizeWords
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var words = new List<string>();

            while (inputLine != "end")
            {
                inputLine = Capitalize(inputLine);

                Console.WriteLine(string.Join(", ", inputLine));

                inputLine = Console.ReadLine();

            }           


        }

        private static string Capitalize(string inputLine)
        {
            for (int i = 0; i < inputLine.Length; i++)
            {
                if (!char.IsLetter(inputLine[i]) && inputLine[i]!='\'')
                {
                    inputLine = inputLine.Replace(inputLine[i], ' ');
                }
            }

            var separate = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var result = new List<string>();

            foreach (var word in separate)
            {
                var newword = new StringBuilder( word.ToLower());

                newword[0] = char.ToUpper(newword[0]);

                result.Add(string.Join("", newword));
            }


            return string.Join(", ", result);
        }      
    }
}
