using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05MagicExchangeableWords
{
    class Task05MagicExchangeableWords
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(' ');

            string firstWord = input[0];

            string secondWord = input[1];

            bool result = AreTheWordsExchangeable(firstWord, secondWord);

            if (result)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        private static bool AreTheWordsExchangeable(string firstWord, string secondWord)
        {

            var firstDistinct = firstWord.ToCharArray().Distinct().ToArray();

            var secondDistinct = secondWord.ToCharArray().Distinct().ToArray();

            var firstWordSafe = firstWord;

            var secondWordSafe = secondWord;

            if (firstDistinct.Length!=secondDistinct.Length)
            {
                return false;
            }

            var firstResult = string.Empty;
            
            return true;
        }
    }
}
