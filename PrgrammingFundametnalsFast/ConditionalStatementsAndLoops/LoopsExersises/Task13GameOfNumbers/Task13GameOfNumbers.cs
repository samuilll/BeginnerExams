using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task13GameOfNumbers
{
    static void Main(string[] args)
    {

        var firstNumber = int.Parse(Console.ReadLine());

        var secondNumber = int.Parse(Console.ReadLine());

        var magicNumber = int.Parse(Console.ReadLine());

        var combinations = 0;

        var firstMagic = 0;

        var secondMagic = 0;

        var combinationIsFound = false;

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            for (int j = firstNumber; j <= secondNumber; j++)
            {

                combinations++;

                if (i + j == magicNumber)
                {
                    firstMagic = i;

                    secondMagic = j;

                    combinationIsFound = true;
                }
            }
        }

        if (combinationIsFound)
        {
            Console.WriteLine($"Number found! {firstMagic} + {secondMagic} = {magicNumber}");
        }
        else
        {
            Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
        }
    }
}

