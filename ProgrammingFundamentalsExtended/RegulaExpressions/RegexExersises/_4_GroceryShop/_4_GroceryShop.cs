using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class _4_GroceryShop
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        var regex = new Regex(@"\b(?<name>[A-Z][a-z]+):(?<number>\d+\.\d{2})$");

        var products = new Dictionary<string, decimal>();



        while (input != "bill")
        {
            var separate = input.Split(':').ToArray();

            var match = regex.Match(input);

            if (match.Success)
            {

                var productName = match.Groups["name"].Value;

                var productPrice = decimal.Parse(match.Groups["number"].Value);

                products[productName] = productPrice;
            }


            input = Console.ReadLine();

        }

        foreach (var product in products.OrderByDescending(n => n.Value))
        {
            Console.WriteLine("{0} costs {1:f2}", product.Key, product.Value);
        }
    }
}

