using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckZipper06
{
    class StuckZipper06
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse).
              ToList();

            var secondLine = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse).
              ToList();

            var outputLine = new List<int>();

            int digits1 = MaxAllowedDigits(firstLine);

           int digits2 = MaxAllowedDigits(secondLine);

            int allowedDigits = Math.Min(digits1, digits2);

            RemoveExtraDigitsNumbers(firstLine, allowedDigits);

            RemoveExtraDigitsNumbers(secondLine, allowedDigits);

            FullTheOutPutLine(firstLine, secondLine, outputLine);





    //        Console.WriteLine(string.Join(" ",firstLine));

      //      Console.WriteLine(string.Join(" ", secondLine));

            Console.WriteLine(string.Join(" ", outputLine));




        }

        private static void FullTheOutPutLine(List<int> firstLine, List<int> secondLine, List<int> outputLine)
        {
            var maxCount = Math.Max(firstLine.Count, secondLine.Count);
            

            for (int i = 0; i < maxCount; i++)
            {
                if (i<secondLine.Count)

                outputLine.Add(secondLine[i]);

                if(i<firstLine.Count)

                outputLine.Add(firstLine[i]);
            }
        }

        private static void RemoveExtraDigitsNumbers(List<int> integers, int allowedDigits)
        {
            for (int i = 0; i < integers.Count; i++)
            {
                var countOfDigits = 0;

                var number = integers[i];

                while (number != 0)
                {
                    number = number / 10;
                    countOfDigits++;
                }

                if (countOfDigits > allowedDigits)
                {
                    integers.Remove(integers[i]);

                    i--;
                }

                countOfDigits = 0;
            }

        }

        private static int MaxAllowedDigits(List<int> integers)
        {
            var minCountOfDigits = int.MaxValue;

            for (int i = 0; i < integers.Count; i++)
            {
                var countOfDigits = 0;

                var number = integers[i];

                while (number != 0)
                {
                   number =  number / 10;
                    countOfDigits++;
                }

                if (countOfDigits<minCountOfDigits)
                {
                    minCountOfDigits = countOfDigits;
                }

                countOfDigits = 0;
            }

            return minCountOfDigits;
        }
    }
}
