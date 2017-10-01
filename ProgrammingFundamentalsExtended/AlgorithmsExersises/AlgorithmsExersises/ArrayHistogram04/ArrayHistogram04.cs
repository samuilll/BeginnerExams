using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHistogram04
{
    class ArrayHistogram04
    {
        static void Main(string[] args)
        {

            List<string> words = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            //   SortTheListByInsertionAlgorithm(words);

            //    words.Reverse();



            var helpArray = new int[words.Count];

            CountTheWordsOccurance(words, helpArray);

            //  Array.Sort(helpArray);

            //  Array.Reverse(helpArray);

         //   Console.WriteLine(string.Join(" ", helpArray));

         //   Console.WriteLine(string.Join(" ", words));

            words.Sort();

            words.Reverse();

          //  Console.WriteLine(string.Join(" ", words));





            for (int i = 0; i < words.Count; i += int.Parse(Convert.ToString(words[i][0])))
            {
                int count = int.Parse(Convert.ToString(words[i][0]));
                string word = "";
                for (int j = 1; j < words[i].Length; j++)
                {

                    word += words[i][j];

                }
                double percentage = (double)count / words.Count * 100;
                Console.WriteLine($"{word} -> {words[i][0]} times ({percentage:f2}%)");
            }


        }

        private static void CountTheWordsOccurance(List<string> words, int[] helpArray)
        {
            for (int i = 0; i < words.Count; i++)
            {
                var count = 0;

                for (int j = 0; j < words.Count; j++)
                {
                    if (words[i] == words[j])
                    {
                        count += 1;
                    }
                }

                helpArray[i] = count;
            }

            AddOccurencesInTheList(words, helpArray);
        }

        private static void AddOccurencesInTheList(List<string> words, int[] helpArray)
        {
            for (int i = 0; i < helpArray.Length; i++)
            {
                words[i] = Convert.ToString(helpArray[i]) + words[i];
            }
        }

  ////      private static void SortTheListByInsertionAlgorithm(List<string> words)
  //      {
  //          for (int firstIndex = 0; firstIndex < words.Count - 1; firstIndex++)
  //          {
  //              //  var count = 1;
  //              for (int secondIndex = firstIndex + 1; secondIndex < words.Count; secondIndex++)
  //              {
  //                  if (words[secondIndex].CompareTo(words[firstIndex]) == 0)
  //                  {
  //                      string temporary = words[secondIndex];
  //                      words[secondIndex] = words[firstIndex + 1];
  //                      words[firstIndex + 1] = temporary;
  //                      break;

  //                      //   secondIndex--;
  //                  }

  //              }

  //          }
   //     }
    }
}

