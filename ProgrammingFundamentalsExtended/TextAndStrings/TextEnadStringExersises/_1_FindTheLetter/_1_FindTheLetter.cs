using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _1_FindTheLetter
{
    static void Main(string[] args)
    {
        var text = Console.ReadLine();

        var letterAndNumber = Console.ReadLine().Split().ToArray();

        var letter = Convert.ToChar(letterAndNumber[0]);

        var occurencesNumber = int.Parse(letterAndNumber[1]);

        var counter = 0;

       var index = -1;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == letter)
            {
                counter++;
            }
            if (counter==occurencesNumber)
            {
                index = i;
                break;
            }
        }
        if (counter == occurencesNumber)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("Find the letter yourself!");
        }

    }
}

