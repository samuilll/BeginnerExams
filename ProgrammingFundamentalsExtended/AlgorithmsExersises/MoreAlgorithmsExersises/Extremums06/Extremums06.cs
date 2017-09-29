using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extremums06
{
    class Extremums06
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .ToList();

            var outputList = new List<int>();

            var command = Console.ReadLine();

            var sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                var newNumber = FindTheMinOrMaxNumber(numbers[i], command);

                outputList.Add(newNumber);

                sum += newNumber;
            }

            Console.WriteLine(string.Join(", ", outputList));

            Console.WriteLine(sum);
        }

        private static int FindTheMinOrMaxNumber(string numberOne, string command)
        {
            int leftMinOrMax = LeftRotationMinOrMax(numberOne, command);

            int rightMinOrMax = RightRotationMinOrMax(numberOne, command);


            if (command == "Max")
            {
                return Math.Max(leftMinOrMax, rightMinOrMax);
            }

            else
            {
                return Math.Min(leftMinOrMax, rightMinOrMax);
            }
        }

        private static int RightRotationMinOrMax(string numberOne, string command)
        {
            var newNumber = "";

            var maxNumber = int.MinValue;

            var minNumber = int.MaxValue;

            var count = 0;

            while (count < numberOne.Length)
            {
                newNumber += numberOne[numberOne.Length - 1];

                for (int i = 0; i < numberOne.Length - 1; i++)
                {
                    newNumber += numberOne[i];
                }

                if (int.Parse(numberOne) < minNumber)
                {
                    minNumber = int.Parse(numberOne);
                }

                if (int.Parse(numberOne) > maxNumber)
                {
                    maxNumber = int.Parse(numberOne);

                }

                numberOne = newNumber;

                newNumber = "";

                count++;
            }

            if (command == "Min")
            {
                return minNumber;
            }

            else
            {
                return maxNumber;
            }

        }


        private static int LeftRotationMinOrMax(string numberOne, string command)
        {
            var newNumber = "";

            var maxNumber = int.MinValue;

            var minNumber = int.MaxValue;

            var count = 0;

            while (count < numberOne.Length)
            {
                for (int i = 1; i < numberOne.Length; i++)
                {
                    newNumber += numberOne[i];
                }

                newNumber += numberOne[0];

                if (int.Parse(numberOne) < minNumber)
                {
                    minNumber = int.Parse(numberOne);
                }

                if (int.Parse(numberOne) > maxNumber)
                {
                    maxNumber = int.Parse(numberOne);

                }

                numberOne = newNumber;

                newNumber = "";

                count++;
            }

            if (command == "Min")
            {
                return minNumber;
            }

            else
            {
                return maxNumber;
            }

        }
    }
}
