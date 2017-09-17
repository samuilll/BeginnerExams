using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHistogramBetter
{
    class ArrayHistogramBetter
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .ToList();

            List<string> noRepeatedWords = new List<string>();

            List<int> countedWords = new List<int>();

            InputAndCountWords(words, noRepeatedWords, countedWords);

            

            BubbleSort(noRepeatedWords, countedWords);

         //   noRepeatedWords.Reverse();

         //   countedWords.Reverse();

            PrintTheRequiredResults(noRepeatedWords, countedWords,words);

       //     Console.WriteLine(string.Join(" ", noRepeatedWords));

        //    Console.WriteLine(string.Join(" ", countedWords));

        }

        private static void PrintTheRequiredResults(List<string> noRepeatedWords, List<int> countedWords, List<string> words)
        {
            for (int i = 0; i < noRepeatedWords.Count; i++)
            {
                double percentage = (double)countedWords[i] / words.Count * 100;
                Console.WriteLine($"{noRepeatedWords[i]} -> {countedWords[i]} times ({percentage:f2}%)");
            }
        }

        private static void InputAndCountWords(List<string> words, List<string> noRepeatedWords, List<int> countedWords)
        {
            for (int i = 0; i < words.Count; i++)
            {
                if (noRepeatedWords.Contains(words[i]))
                {
                    var index = noRepeatedWords.IndexOf(words[i]);

                    countedWords[index]++;
                }
                else
                {
                    noRepeatedWords.Add(words[i]);

                    countedWords.Add(1);
                }
            }
        }

        private static void BubbleSort(List<string> newWords,List<int> numbers)
        {
            var check = true;

            while (check)
            {

                check = false;

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                        var temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;

                        var newtemp = newWords[i];
                        newWords[i] = newWords[i + 1];
                        newWords[i + 1] = newtemp;


                        check = true;
                    }
                }
            }
        }
    }
}
