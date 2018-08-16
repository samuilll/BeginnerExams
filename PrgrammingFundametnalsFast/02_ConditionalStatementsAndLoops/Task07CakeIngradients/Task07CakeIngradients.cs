using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task07CakeIngradients
{
    static void Main(string[] args)
    {
        string ingredient = Console.ReadLine();

        int counter = 0;

        while (ingredient!="Bake!")
        {
            Console.WriteLine($"Adding ingredient {ingredient}.");

            ingredient = Console.ReadLine();

            counter++;
        }

        Console.WriteLine($"Preparing cake with {counter} ingredients.");

    }
}

