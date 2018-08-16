using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task01LargestCommonEnd
{
    static void Main(string[] args)
    {

        string[] firstSequence = Console.ReadLine()
     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
     .ToArray();

        string[] secondSequence = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

        int startCounter = 0;

        int endCounter = 0;

        for (int i = 0, firstLastIndex = firstSequence.Length - 1, secondLastIndex = secondSequence.Length - 1;
            i < firstSequence.Length && i < secondSequence.Length; i++,firstLastIndex--,secondLastIndex--)
        {
            if (firstSequence[i]==secondSequence[i])
            {
                startCounter++;
            }
            if (firstSequence[firstLastIndex]==secondSequence[secondLastIndex])
            {
                endCounter++;
            }
        }

            Console.WriteLine(startCounter >= endCounter ? startCounter : endCounter);
        



    }
    }

