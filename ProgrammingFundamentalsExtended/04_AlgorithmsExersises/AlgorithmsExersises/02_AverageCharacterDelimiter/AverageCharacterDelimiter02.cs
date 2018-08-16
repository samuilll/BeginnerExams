using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCharacterDelimiter02
{
    class AverageCharacterDelimiter02
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int average = (FindTheAverageValue(words));

            char delimiter = Convert.ToChar(average);

            delimiter = Char.ToUpper(delimiter);

            Console.WriteLine(string.Join($"{delimiter}",words));

          
        }

        private static int FindTheAverageValue(List<string> words)
        {
            int sum = 0;

            int countOfDigits = 0;

            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    sum+=(int)words[i][j];

                    countOfDigits += 1;
                }
            }

            return sum / countOfDigits;
        }
    }
}
