using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task08CaloriesCounter
{
    static void Main(string[] args)
    {

        var linesNumber = int.Parse(Console.ReadLine());

        string[] ingradients = new string[] { "cheese", "domato sauce", "salami", "pepper" };

        int[] prices = new int[] { 500, 150, 600, 50 };

        int allCalories = 0;

        for (int i = 0; i < linesNumber; i++)
        {
            var currentIngredient = Console.ReadLine().ToLower();

            switch (currentIngredient)
            {
                case "cheese":
                    allCalories += prices[0];
                    break;
                case "tomato sauce":
                    allCalories += prices[1];
                    break;
                case "salami":
                    allCalories += prices[2];
                    break;
                case "pepper":
                    allCalories += prices[3];
                    break;
                default:
                    break;

            }
        }

        Console.WriteLine($"Total calories: { allCalories}");
    }
}

