using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ExamShopping
{
    class _4_ExamShopping
    {
        static void Main(string[] args)
        {
            var stocks = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

            var marketQuantities = new Dictionary<string, int>();

            while (stocks[0] != "shopping")
            {
                var product = stocks[1];

                var quantity = int.Parse(stocks[2]);

                StockTheMarket(product, quantity, marketQuantities);

                stocks = Console.ReadLine()
          .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
          .ToArray();
            }

            do
            {

                stocks = Console.ReadLine()
          .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
          .ToArray();

                if (stocks[0] == "exam")
                {
                    break;
                }

                var product = stocks[1];

                var quantity = int.Parse(stocks[2]);

                BuyTheProduct(product, quantity, marketQuantities);

            } while(true);

            PrintTheRemainingInventory(marketQuantities);
        }

        private static void PrintTheRemainingInventory(Dictionary<string, int> marketQuantities)
        {
            foreach (var kvp in marketQuantities)
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }

        private static void BuyTheProduct(string product, int quantity, Dictionary<string, int> marketQuantities)
        {
            if (!marketQuantities.ContainsKey(product))
            {
                Console.WriteLine($"{product} doesn't exist");
            }
            else if (marketQuantities[product] <= 0)
            {
                Console.WriteLine($"{product} out of stock");
            }
            else
            {
                marketQuantities[product] -= quantity;
            }
        }

        private static void StockTheMarket(string product, int quantity, Dictionary<string, int> marketQuantities)
        {
            if (!marketQuantities.ContainsKey(product))
            {
                marketQuantities[product] = quantity;
            }
            else
            {
                marketQuantities[product] += quantity;

            }
        }
    }
}
