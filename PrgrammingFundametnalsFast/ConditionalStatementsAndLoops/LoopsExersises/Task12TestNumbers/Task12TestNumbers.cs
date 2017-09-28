using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task12TestNumbers
{
    static void Main(string[] args)
    {

        var firstNumber = int.Parse(Console.ReadLine());

        var secondNumber = int.Parse(Console.ReadLine());

        var thirdNumber = int.Parse(Console.ReadLine());

        var combinations = 0;

        var sum = 0;

        var checkTheSum = false;

        for (int i = firstNumber; i >= 1; i--)
        {
            for (int j = 1; j <= secondNumber; j++)
            {
           
                sum += 3 * i * j;

                combinations++;

                if (sum>=thirdNumber)
                {
                    checkTheSum = true;
                    goto Outer;
                }
            }

        }

        Outer:;

        if (checkTheSum)
        {
            Console.WriteLine($"{combinations} combinations\nSum: {sum} >= {thirdNumber}");
        }
        else
        {
            Console.WriteLine($"{combinations} combinations\nSum: {sum}");
        }

    }
}
