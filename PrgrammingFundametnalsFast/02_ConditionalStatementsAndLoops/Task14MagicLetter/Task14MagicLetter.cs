using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task14MagicLetter
    {
        static void Main(string[] args)
        {

        char firstLetter = char.Parse(Console.ReadLine());

        char secondLetter = char.Parse(Console.ReadLine());

        char unwantedLetter = char.Parse(Console.ReadLine());

        for (char i = firstLetter; i <= secondLetter; i++)
        {
            for (char j = firstLetter; j <= secondLetter; j++)
            {
                for (char p = firstLetter; p <= secondLetter; p++)
                {
                    if (i!=unwantedLetter && j!=unwantedLetter && p!=unwantedLetter)
                    {
                        Console.Write($"{i}{j}{p} ");
                    }
                }
            }
        }


    }
}

