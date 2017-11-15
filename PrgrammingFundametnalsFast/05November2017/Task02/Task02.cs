using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Task02
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                var line = Console.ReadLine();

                var splittedLine = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (line == "3:1")
                {
                    break;
                }

                if (splittedLine[0] == "merge")
                {
                    MergeFunction(splittedLine, input);
                }
                if (splittedLine[0] == "divide")
                {
                    DivideFunction(splittedLine, input);
                }
                   Console.WriteLine(string.Join(" ", input));

            }
          //  Console.WriteLine(string.Join(" ", input));

        }

        private static void DivideFunction(string[] splittedLine, List<string> input)
        {
            var startIndex = int.Parse(splittedLine[1]);

            var partisions = int.Parse(splittedLine[2]);

            if (startIndex >= input.Count || startIndex < 0)
            {
                return;
            }

            StringBuilder stringBuild = new StringBuilder();

            var word = input[startIndex];

            input.RemoveAt(startIndex);

            var temp = new List<string>();

            var length = word.Length / partisions;

            var lastLength = length + word.Length % partisions; 



            for (int i = 0; i < word.Length; i++)
            {
                stringBuild.Append(word[i]);

                if ((i + 1) % length == 0)
                {
                    temp.Add(stringBuild.ToString());

                    stringBuild = new StringBuilder();
                }
 
            }
            if (word.Length % partisions != 0)
            {
                temp[temp.Count - 2] = temp[temp.Count - 2] + temp[temp.Count - 1];
                temp.RemoveAt(temp.Count - 1);
            }
            if (stringBuild.Length != 0)
            {
                temp[temp.Count - 1] += stringBuild.ToString();
            }

            //      var index = 0;

            for (int i = startIndex, j = 0; j < temp.Count; i++, j++)
            {
                input.Insert(i, temp[j]);

                // index = i;
            }
            //  index--;

            //if (stringBuild.Length!=0)
            //{
            //    input[index] = input[index] + stringBuild.ToString();
            //}



        }

        private static void MergeFunction(string[] splittedLine, List<string> input)
        {
            var startIndex = int.Parse(splittedLine[1]);

            if (startIndex < 0)
            {
                startIndex = 0;
            }
            var endIndex = int.Parse(splittedLine[2]);

            if (endIndex >= input.Count)
            {
                endIndex = input.Count - 1;
            }
            if (startIndex >= input.Count || endIndex < 0)
            {
                return;
            }

            var built = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                built.Append(input[i]);
            }
            input.RemoveRange(startIndex, endIndex - startIndex + 1);

            input.Insert(startIndex, built.ToString());

        }
    }
}