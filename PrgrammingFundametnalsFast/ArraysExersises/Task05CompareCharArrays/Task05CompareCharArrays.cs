using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task05CompareCharArrays
    {
        static void Main(string[] args)
        {

        char[] firstLetterSequence = Console.ReadLine()
         .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
         .Select(char.Parse)
         .ToArray();

        char[] secondLetterSequence = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();

        bool firstIsFirstInOrder = false;

       
            for (int i = 0,j=0; i < firstLetterSequence.Length && j<secondLetterSequence.Length; i++,j++)
            {
                if (firstLetterSequence[i]<secondLetterSequence[j])
                {
                    firstIsFirstInOrder = true;
                    break;
                }
                else if ((firstLetterSequence[i] > secondLetterSequence[i]))
                {
                    firstIsFirstInOrder = false;
                    break;
                }
            else
            {
                if (i==firstLetterSequence.Length-1)
                {
                    firstIsFirstInOrder = true;
                    break;
                }
                if (j == secondLetterSequence.Length-1)
                {
                    firstIsFirstInOrder = false;
                    break;
                }
            }
            }

        if (firstIsFirstInOrder)
        {
            Console.WriteLine(string.Join("",firstLetterSequence));
            Console.WriteLine(string.Join("", secondLetterSequence));
        }
        else
        {
            Console.WriteLine(string.Join("", secondLetterSequence));
            Console.WriteLine(string.Join("", firstLetterSequence));
        }
    }
}

