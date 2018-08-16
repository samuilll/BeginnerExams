using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task11EqualSums
{
    static void Main(string[] args)
    {
        var lines = File.ReadAllLines("input.txt");

        int[] numbers = lines[0]
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        File.Delete("output.txt");

        File.AppendAllText("output.txt",IsThereSatsfyingIndex(numbers));
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
            for (int rightIndex = numbers.Length - 1; rightIndex > index; rightIndex--)
            {
                rightSum += numbers[rightIndex];
            }

            if (leftSum == rightSum)
            {
                return index.ToString();
            }

            leftSum = 0;
            rightSum = 0;
        }

        return "no";
    }
}