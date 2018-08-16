using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task09CountTheIntegers
{
    static void Main(string[] args)
    {
        int counter = 0;

        while (true)
        {
            var input = Console.ReadLine();

            if (int.TryParse(input,out int number))
            {
                counter++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(counter);
    }
}

