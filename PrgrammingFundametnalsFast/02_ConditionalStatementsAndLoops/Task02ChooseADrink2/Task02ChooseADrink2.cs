using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task02ChooseADrink2
{
    static void Main(string[] args)
    {
        string profession = Console.ReadLine();

        int quantity = int.Parse(Console.ReadLine());

        double[] prices = new double[] { 0.70, 1.0, 1.70, 1.20 };

        double totalPrice = 0;

        if (profession == "Athlete")
        {
            totalPrice = prices[0] * quantity;
        }
        else if (profession == "Businessman" || profession == "Businesswoman")
        {
            totalPrice = prices[1] * quantity;
        }
        else if (profession == "SoftUni Student")
        {
            totalPrice = prices[2] * quantity;
        }
        else
        {
            totalPrice = prices[3] * quantity;
        }

        Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");

    }
}

