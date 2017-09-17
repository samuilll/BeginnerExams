using System;

class TruckDriver03
{
    static void Main(string[] args)
    {
        string Season = Console.ReadLine();
        var kilometers = double.Parse(Console.ReadLine());
        var profit = 0.0;
        switch (Season)
        {
            case "Spring":
                {
                    if (kilometers <= 5000) profit = kilometers * 0.75 * 4 - kilometers * 0.75 * 4.0 * 10 / 100;
                    else if (kilometers > 5000 && kilometers <= 10000) profit = kilometers * 0.95 * 4.0 - kilometers * 0.95 * 4 * 10 / 100;
                    else profit = kilometers * 1.45 * 4 - kilometers * 1.45 * 4 * 10 / 100;
                    break;
                }
            case "Autumn":
                {
                    if (kilometers <= 5000) profit = kilometers * 0.75 * 4 - kilometers * 0.75 * 4.0 * 10 / 100;
                    else if (kilometers > 5000 && kilometers <= 10000) profit = kilometers * 0.95 * 4.0 - kilometers * 0.95 * 4 * 10 / 100;
                    else profit = kilometers * 1.45 * 4 - kilometers * 1.45 * 4 * 10 / 100;
                    break;

                }
            case "Winter":
                {
                    if (kilometers <= 5000) profit = kilometers * 1.05 * 4 - kilometers * 1.05 * 4.0 * 10 / 100;
                    else if (kilometers > 5000 && kilometers <= 10000) profit = kilometers * 1.25 * 4.0 - kilometers * 1.25 * 4 * 10 / 100;
                    else profit = kilometers * 1.45 * 4 - kilometers * 1.45 * 4 * 10 / 100;
                    break;
                }
            case "Summer":
                {
                    if (kilometers <= 5000) profit = kilometers * 0.9 * 4 - kilometers * 0.9 * 4.0 * 10 / 100;
                    else if (kilometers > 5000 && kilometers <= 10000) profit = kilometers * 1.10 * 4.0 - kilometers * 1.10 * 4 * 10 / 100;
                    else profit = kilometers * 1.45 * 4 - kilometers * 1.45 * 4 * 10 / 100;
                    break;

                }
       }
        Console.WriteLine( "{0:f2}",profit);
    }
}

