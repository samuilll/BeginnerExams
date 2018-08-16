using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _4_MostValuedCustomer
{
    static void Main(string[] args)
    {

        var productList = new Dictionary<string, decimal>();

        var Totals = new Dictionary<string, decimal>();

        var customersHistory = new Dictionary<string, Dictionary<string, decimal>>();


        var inputLine = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        while (inputLine[0] != "Shop")
        {
            var product = inputLine[0];

            var price = decimal.Parse(inputLine[1]);

            FillTheProductList(productList, product, price);

            inputLine = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        }

        inputLine = Console.ReadLine()
            .Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        var discountsNumber = 0;

        while (inputLine[0] != "Print")
        {
            if (inputLine.Count > 1)
            {
                var name = inputLine[0];

                var products = inputLine[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                FillTheCustomersDataList(productList, customersHistory, name, products);
            }
            else
            {
                discountsNumber++;
            }

            inputLine = Console.ReadLine()
                .Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
        }


        for (int i = 0; i < discountsNumber; i++)
        {

            var discountProducts = new Dictionary<string, decimal>();

            discountProducts = DiscountFunction(productList);

            productList = productList.
                   OrderByDescending(n => n.Value)
                   .Skip(3)
                   .ToDictionary(n => n.Key, n => n.Value);

            productList = productList
                .Concat(discountProducts)
                .OrderByDescending(n => n.Value)
                .ToDictionary(n => n.Key, n => n.Value);
        }

        RecalculateDependingOnDescents(productList, customersHistory, Totals);

        Totals = Totals
           .OrderByDescending(n => n.Value)
           .ToDictionary(n => n.Key, n => n.Value);

        var mostValuableCustomer = Totals.Keys.First();

        Console.WriteLine($"Biggest spender: {mostValuableCustomer}");

        Console.WriteLine("^Products bought:");

        foreach (var pair in customersHistory[mostValuableCustomer].OrderByDescending(n=>n.Value))
        {
            Console.WriteLine($"^^^{pair.Key}: {pair.Value:f2}");
        }

        Console.WriteLine($"Total: {Totals[mostValuableCustomer]:f2}");

    }

    private static void RecalculateDependingOnDescents(Dictionary<string, decimal> productList,
        Dictionary<string, Dictionary<string, decimal>> customersHistory, Dictionary<string, decimal> totals)
    {
        var names = customersHistory.Select(n => n.Key).ToArray();

        for (int i = 0; i <names.Length; i++)
        {
            var name = names[i];

            var foods = customersHistory[name].Select(n => n.Key).ToArray();

            for (int j = 0; j < foods.Length; j++)
            {
                var food = foods[j];

                if (!totals.ContainsKey(name))
                {
                    totals[name] = 0;
                }
                totals[name] =totals[name] + customersHistory[name][food] * productList[food];

                customersHistory[name][food] = productList[food];
            }

        }
    }
    private static Dictionary<string, decimal> DiscountFunction(Dictionary<string, decimal> productsList)
    {
        return productsList
              .OrderByDescending(n => n.Value)
              .Take(3)
            .ToDictionary(n => n.Key, n => n.Value - n.Value / 10);

        ;

        //    customersHistory = customersHistory.

    }

    private static void FillTheCustomersDataList(Dictionary<string, decimal> productList, Dictionary<string,
            Dictionary<string, decimal>> customersHistory, string name, string[] products)
    {
        if (!customersHistory.ContainsKey(name))
        {
            customersHistory[name] = new Dictionary<string, decimal>();
        }
        for (int i = 0; i < products.Count(); i++)
        {
            var currentProduct = products[i];

            bool isThere = productList.ContainsKey(currentProduct);

            if (!customersHistory[name].ContainsKey(currentProduct) && isThere)
            {
                customersHistory[name][currentProduct] = 0;
            }
            if (isThere)
            {
                customersHistory[name][currentProduct] += 1;
            }
           
        }
    }

    private static void FillTheProductList(Dictionary<string, decimal> productList, string product, decimal price)
    {
        productList[product] = price;
    }
}

