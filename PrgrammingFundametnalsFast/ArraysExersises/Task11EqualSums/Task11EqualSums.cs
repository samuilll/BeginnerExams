using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task11EqualSums
{
    static void Main(string[] args)
    {

        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        string result = IsThereSatsfyingIndex(numbers);

        Console.WriteLine(result);
    }

    private static string IsThereSatsfyingIndex(int[] numbers)
    {
        int leftSum = 0;

        int rightSum = 0;

        for (int index = 0; index < numbers.Length; index++)
        {
            for (int leftIndex = 0; leftIndex < index; leftIndex++)
            {
                leftSum += numbers[leftIndex];
            }
            for (int rightIndex = numbers.Length-1; rightIndex > index; rightIndex--)
            {
                rightSum += numbers[rightIndex];
            }

            if (leftSum==rightSum)
            {
                return index.ToString();
            }

            leftSum = 0;
            rightSum = 0;
        }

        return "no";
    }
}

