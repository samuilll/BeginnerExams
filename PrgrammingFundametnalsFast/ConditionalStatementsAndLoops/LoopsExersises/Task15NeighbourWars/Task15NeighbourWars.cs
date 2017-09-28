using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task15NeighbourWars
{
    static void Main(string[] args)
    {

        var goshoHealth = 100;

        var peshoHealth = 100;

        var peshoDamage = int.Parse(Console.ReadLine());

        var goshoDamage = int.Parse(Console.ReadLine());

        var rounds = 1;

        var winner = string.Empty;

        while (true)
        {
            if (rounds%2==0)
            {
                peshoHealth-=goshoDamage;

                if (peshoHealth>0)
                {
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
                else
                {
                    winner = "Gosho";
                    break;
                }
            }
            else
            {
                goshoHealth-=peshoDamage;

                if (goshoHealth>0)
                {
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");

                }
                else
                {
                    winner = "Pesho";
                    break;
                }
            }

            if (rounds%3==0 && goshoHealth > 0 && peshoHealth > 0)
            {
                goshoHealth += 10;
                peshoHealth += 10;
            }

            rounds++;
        }

        Console.WriteLine($"{winner} won in {rounds}th round.");

    }
}

