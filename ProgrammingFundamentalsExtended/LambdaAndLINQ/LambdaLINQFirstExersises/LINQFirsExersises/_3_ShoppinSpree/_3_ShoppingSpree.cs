using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var budget = decimal.Parse(Console.ReadLine());

        var inputLine = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        var productList = new Dictionary<string, decimal>();

        while (inputLine[0] != "end")
        {
            var product = inputLine[0];

            var price = decimal.Parse(inputLine[1]);

            FillTheProductList(productList, product, price);

            inputLine = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        var allProductsPrice = productList
            .Select(n => n.Value)
            .ToList()
            .Sum();

        if (allProductsPrice<=budget)
        {
            PrintTheResult(productList);
        }
        else
        {
            Console.WriteLine("Need more money... Just buy banichka");
        }
    }

    private static void PrintTheResult(Dictionary<string, decimal> productList)
    {
        productList
            .OrderByDescending(n => n.Value)
            .ThenBy(n => n.Key.Length)  
            .Select(n => n.Key + " costs " + string.Format($"{n.Value:f2}"))
            .ToList()
            .ForEach(n=>Console.WriteLine(n));
    }

    private static void FillTheProductList(Dictionary<string, decimal> productList, string product, decimal price)
    {
        if (!productList.ContainsKey(product))
        {
            productList[product] = price;
        }
        else if (productList[product]>price)
        {
            productList[product] = price;
        }
    }
}

