using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task06SumReversedNumbers
{
    static void Main(string[] args)
    {
        var sequence = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        int sum = 0;

        foreach (var number in sequence)
        {
            sum += MirrorNumber(number);
        }

        Console.WriteLine(sum);
    }

    private static int MirrorNumber(int i)
    {
        int originalNumber = i;

        int digitsCount = 0;

        while (i > 0)
        {
            digitsCount++;

            i /= 10;
        }

        i = originalNumber;

        int toAdd = (int)Math.Pow(10, digitsCount - 1);

        int resultNumber = 0;

        while (i > 0)
        {
            resultNumber += i % 10 * toAdd;

            i /= 10;
            toAdd /= 10;
        }
        
        return resultNumber;
    }
}

