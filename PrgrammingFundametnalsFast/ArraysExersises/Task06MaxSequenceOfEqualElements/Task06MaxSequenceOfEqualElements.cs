using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task06MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
        int[] numbers = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

        int maxEndIndex = -1;

        int maxLength = 0;

        int currentLength = 1;

        for (int i = 0; i < numbers.Length - 1; i++)
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

            maxEndIndex = numbers.Length - 1;
        }

        if (maxLength > 1)
        {
            for (int i = maxEndIndex - maxLength + 1; i <= maxEndIndex; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
    }

