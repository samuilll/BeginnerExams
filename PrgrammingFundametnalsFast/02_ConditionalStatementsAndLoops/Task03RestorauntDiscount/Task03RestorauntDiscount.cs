using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task03RestorauntDiscount
{
    static void Main(string[] args)
    {
        int people = int.Parse(Console.ReadLine());

        string package = Console.ReadLine();

        string[] halls = new string[] { "Small Hall", "Terrace", "Great Hall" };

        int[] prices = new int[] { 2500, 5000, 7500 };

        string[] packages = new string[] { "Normal", "Gold", "Platinum" };

        int[] packagePrices = new int[] { 500, 750, 1000 };

        string hall = string.Empty;

        double totalPrice = 0;

        if (people<=50)
        {
            totalPrice += prices[0];

            hall = halls[0];
        }
        else if (people<=100)
        {
            totalPrice += prices[1];

            hall = halls[1];

        }
        else if(people<=120)
        {
            totalPrice += prices[2];

            hall = halls[2];

        }
        else
        {
            Console.WriteLine("We do not have an appropriate hall.");
        }

        if (package == packages[0])
        {
            totalPrice += packagePrices[0];

            totalPrice = totalPrice - (5 * totalPrice / 100);
        }
        else if (package == packages[1])
        {
            totalPrice += packagePrices[1];
            totalPrice = totalPrice - (10 * totalPrice / 100);

        }
        else 
        {
            totalPrice += packagePrices[2];

            totalPrice = totalPrice - (15 * totalPrice / 100);
        }

        if (people<=120)
        {
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {totalPrice / people:f2}$");
        }
       

    }
}

