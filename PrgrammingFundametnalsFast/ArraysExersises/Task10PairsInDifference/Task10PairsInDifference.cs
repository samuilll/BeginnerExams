using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task10PairsInDifference
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
         .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
         .Select(int.Parse)
         .ToArray();

        int specialNumer = int.Parse(Console.ReadLine());

        int result = HowManyPairsIsThereInTheArray(numbers, specialNumer);

        Console.WriteLine(result);
    }

    private static int HowManyPairsIsThereInTheArray(int[] numbers, int specialNumber)
    {
        int pairsNumber = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if ((numbers[i] - numbers[j] == specialNumber)|| numbers[i] - numbers[j] == (specialNumber*(-1)))
                {
                    pairsNumber++;
                }
            }
        }

        return pairsNumber;

    }
}

