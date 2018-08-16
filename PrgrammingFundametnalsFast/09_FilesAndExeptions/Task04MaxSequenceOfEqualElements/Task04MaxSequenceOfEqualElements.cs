using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task01LongestSequenceEqualElements
{
    static void Main(string[] args)
    {

        var lines = File.ReadAllLines("input.txt");

        File.Delete("output.txt");

        var numbers = lines[0]
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        int maxEndIndex = -1;

        int maxLength = 0;

        int currentLength = 1;

        for (int i = 0; i < numbers.Count - 1; i++)
        {

            if (numbers[i] == numbers[i + 1])
            {
                currentLength++;
            }
            else
            {

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;

                    maxEndIndex = i;
                }

                currentLength = 1;
            }
        }

        if (currentLength > maxLength)
        {
            maxLength = currentLength;

            maxEndIndex = numbers.Count - 1;
        }

        for (int i = 0; i < maxLength; i++)
        {
            File.AppendAllText("output.txt",$"{numbers[maxEndIndex]} ");
        }
    }
}