using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task12MasterNumber
{
    static void Main(string[] args)
    {

        int limiter = int.Parse(Console.ReadLine());


        for (int i = 1; i <= limiter; i++)
        {

            if (IsMirror(i) && SumOfTheDigitsAreGood(i) && ThereIsAnOddDigit(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    private static bool IsMirror(int i)
    {
        int originalNumber = i;

        int digitsCount = 0;

        while (i > 0)
        {
            digitsCount++;

            i /= 10;
        }

        i = originalNumber;

        int toAdd = (int)Math.Pow(10,digitsCount-1);

        int resultNumber = 0;

        while (i>0)
        {
            resultNumber += i % 10 * toAdd;

            i /= 10;
            toAdd/=10;
        }
        if (resultNumber==originalNumber)
        {
            return true;
        }
        return false;
    }

    private static bool ThereIsAnOddDigit(int i)
    {
        while (i > 0)
        {
            if ((i % 10) % 2 == 0)
            {
                return true;
                break;
            }

            i /= 10;
        }

        return false;
    }

    private static bool SumOfTheDigitsAreGood(int i)
    {

        int sum = 0;

        while (i > 0)
        {
            sum += i % 10;

            i /= 10;
        }

        if (sum % 7 == 0)
        {
            return true;
        }

        return false;
    }
}

