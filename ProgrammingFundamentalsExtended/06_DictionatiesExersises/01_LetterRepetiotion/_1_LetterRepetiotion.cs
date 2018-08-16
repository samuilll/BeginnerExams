using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LetterRepetiotion
{
    class _1_LetterRepetiotion
    {
        static void Main(string[] args)
        {
            var letters = Console.ReadLine();

            var sortedLetters = new Dictionary<char, int>();

            foreach (var letter in letters)
            {
                if (!sortedLetters.ContainsKey(letter))
                {
                    sortedLetters[letter] = 1;
                }
                else
                {
                    sortedLetters[letter]++;
                }

            }

            foreach (var kvp in sortedLetters)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            
        }
    }
}
