using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04CharacterMultiplier
{
    class Task04CharacterMultiplier
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            string firstWord = input[0];

            string secondWord = input[1];

            int result = GetTheSearchedValue(firstWord, secondWord);

            Console.WriteLine(result);

        }

        private static int GetTheSearchedValue(string firstWord, string secondWord)
        {
            int result = 0;

            int i = 0;

            for (; i < firstWord.Length && i<secondWord.Length; i++)
            {
                result += ((int)firstWord[i]*(int)secondWord[i]);
            }
            while (i<firstWord.Length)
            {
                result += firstWord[i];
                i++;
            }
            while (i<secondWord.Length)
            {
                result += secondWord[i];
                i++;
            }

            return result;
        }
    }
}
