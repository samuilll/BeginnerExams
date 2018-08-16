using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task08MostFrequentNumber
    {
        static void Main(string[] args)
        {

        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int macOccurences = 0;

        int index = 0;

        for (int i = numbers.Length-1; i > 0; i--)
        {
            int currentOccurences = 1;

            int currentIndex = 0;

            for (int j = i-1; j >= 0; j--)
            {                
                if (numbers[i]==numbers[j])
                {
                    currentOccurences++;

                    currentIndex = j;
                }
            }
            if (currentOccurences>=macOccurences)
            {
                macOccurences = currentOccurences;

                index = currentIndex;
            }

            currentOccurences = 1;
        }

        Console.WriteLine(numbers[index]);
    }
    }

