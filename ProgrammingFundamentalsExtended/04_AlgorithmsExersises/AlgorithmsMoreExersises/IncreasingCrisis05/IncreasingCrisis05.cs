using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingCrisis05
{
    class IncreasingCrisis05
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            var outputList = new List<int>();

            for (int i = 0; i < N; i++)
            {
                var Sequences = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

                AddTheIncreasingElements(Sequences, outputList);

                      Console.WriteLine(string.Join(" ", outputList));

                Console.WriteLine();
            }

            Console.WriteLine(string.Join(" ", outputList));

            Console.WriteLine();
        }

        private static void AddTheIncreasingElements(List<int> sequences, List<int> outputList)
        {
            int brokenElementIndex = IsThereABrokenElement(sequences);

            int rightIndexInOutputList = FindTheRightPlaceIneTheList(sequences, outputList);

            InputTheElements(sequences, outputList, brokenElementIndex, rightIndexInOutputList);
        }

        private static void InputTheElements(List<int> sequences, List<int> outputList, int brokenElementIndex, int rightIndexInOutputList)
        {
            var check1 = brokenElementIndex > -1;

            if (check1)
            {
                for (int i = 0; i < brokenElementIndex; i++)
                {
                    outputList.Insert(rightIndexInOutputList, sequences[i]);

                    rightIndexInOutputList++;

                }

                RemoveElementsAgterTheLastAdded(outputList, rightIndexInOutputList);
            }
            else
            {
                for (int i = 0; i < sequences.Count; i++)
                {
                    outputList.Insert(rightIndexInOutputList, sequences[i]);

                    rightIndexInOutputList++;

                }
            }

        }

        private static void RemoveElementsAgterTheLastAdded(List<int> outputList, int rightIndexInOutputList)
        {
            var index = rightIndexInOutputList;

            while (index<outputList.Count)
            {
                outputList.RemoveAt(index);
            }
        }

        private static int FindTheRightPlaceIneTheList(List<int> sequences, List<int> outputList)
        {
            var index = outputList.Count;

            for (int i = 0; i < outputList.Count; i++)
            {
                if (outputList[i] <= sequences[0])
                {
                    index = i + 1;
                }
                if ( outputList[0] > sequences[0])
                {
                    index = 0;

                    break;
                }
            }

            return index;
        }

        private static int IsThereABrokenElement(List<int> sequences)
        {
            var brokenElementIndex = -1;

            for (int i = 1; i < sequences.Count; i++)
            {
                if (sequences[i] < sequences[i - 1])
                {
                    brokenElementIndex = i;
                    break;
                }
            }

            return brokenElementIndex;
        }
    }
}
