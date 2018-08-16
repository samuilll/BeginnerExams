using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {

        var numbersList = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var numbersArray = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var takenNumbers = numbersList.Take(numbersArray[0]).ToList();

        for (int i = 0; i < numbersArray[1]; i++)
        {
            takenNumbers.RemoveAt(0);
        }

        if (takenNumbers.Contains(numbersArray[2]))
        {
            Console.WriteLine("YES!");
        }
        else
        {
            Console.WriteLine("NO!");
        }


    }
}

