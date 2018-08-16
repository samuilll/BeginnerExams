using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOfStrings03
{
    class SortArrayOfStrings03
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            SortTheListByInsertionAlgorithm(words);

            Console.WriteLine(string.Join(" ",words));
        }

        private static void SortTheListByInsertionAlgorithm(List<string> words)
        {
            for (int firstIndex = 1; firstIndex < words.Count; firstIndex++)
            {
                for (int secondIndex = firstIndex; secondIndex > 0; secondIndex--)
                {
                    if (words[secondIndex].CompareTo(words[secondIndex-1])<0)
                    {
                        string temporary = words[secondIndex];
                        words[secondIndex] = words[secondIndex - 1];
                        words[secondIndex - 1] = temporary;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
