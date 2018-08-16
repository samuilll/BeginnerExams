using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class _5_Products
{
    static void Main(string[] args)
    {
        var currentList = new Dictionary<string, Dictionary<string, Product>>();

        var stockedList = new Dictionary<string, Dictionary<string, Product>>();

        var inputLine = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        if (!File.Exists("stock.txt"))
        {
            File.Create("stock.txt").Close();
        }
        else
        {
            LoadTheFile(stockedList);
            LoadTheFile(currentList);
        }
        while (inputLine[0] != "exit")
        {


            if (inputLine.Count > 1)
            {
                FillTheCurrentList(currentList, inputLine);
            }
            else if (inputLine[0] == "sales")
            {
                Console.WriteLine();
                ImplementTheSalesMethod(currentList);               
            }
            else if (inputLine[0]=="stock")
            {
                Console.WriteLine();
                ImplementTheStockMethod(stockedList,currentList);
            }
            else if (inputLine[0]=="analyze")
            {
                Console.WriteLine();
               ImplementTheAnalyzeMethod(stockedList);

            }
            else
            {
                Console.WriteLine("The input was not correct.Please try again");
            }

            inputLine = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        }
    }

    private static void ImplementTheAnalyzeMethod(Dictionary<string, Dictionary<string, Product>> stockedList)
    {
        if (!stockedList.Keys.Any())
        {
            Console.WriteLine("No products stocked");
        }

        else
        {
            foreach (var typeProducts in stockedList.OrderBy(n=>n.Key))
            {
                foreach (var product in typeProducts.Value)
                {
                    Console.WriteLine($"{typeProducts.Key}, Product: {product.Value.Name}");

                    Console.WriteLine($"Price: ${product.Value.Price:f2}, Amount Left: {product.Value.Quantity}");
                }
            }
        }
    }

    private static void LoadTheFile(Dictionary<string, Dictionary<string, Product>> stockedList)
    {
        var lines = File.ReadAllLines("stock.txt");

        foreach (var line in lines)
        {
            var separate = line.Split(' ').ToList();

            var name = separate[0];

            var type = separate[1];

            var price = double.Parse(separate[2]);

            var quantity = int.Parse(separate[3]);

            var currentProduct = new Product(name,price,quantity);

            if (!stockedList.ContainsKey(type))
            {
                stockedList[type] = new Dictionary<string, Product>();
            }

            stockedList[type][name] = currentProduct;
        }
    }

    private static void ImplementTheStockMethod(Dictionary<string, Dictionary<string, Product>> stockedList, Dictionary<string, Dictionary<string, Product>> currentList)
    {
        foreach (var typeProducts in currentList)
        {
            foreach (var product in typeProducts.Value)
            {
                var name = product.Value.Name;

                var type = typeProducts.Key;

                var price = product.Value.Price;

                var quantity = product.Value.Quantity;

                var currentProduct = new Product(name, price, quantity);

                if (!stockedList.ContainsKey(type))
                {
                    stockedList[type] = new Dictionary<string, Product>();
                }

                if (!stockedList[type].ContainsKey(name))
                {
                    stockedList[type][name] = currentProduct;

                    File.AppendAllText("stock.txt", $"{name} {type} {price} {quantity}" + Environment.NewLine);
                }
               
            }
        }
    }

    private static void ImplementTheSalesMethod(Dictionary<string, Dictionary<string, Product>> currentList)
    {
      var sorted =   currentList.
           OrderByDescending(n => n.Value.Values.Select(q => q.Quantity * q.Price).ToList().Sum())
           .ToDictionary(n=>n.Key,n=>n.Value);

        foreach (var pair in sorted)
        {
            var sum = pair.Value.Values.Select(q => q.Quantity * q.Price).ToList().Sum();

            Console.WriteLine($"{pair.Key}: ${sum:f2}");
        }


       }     

    private static void FillTheCurrentList(Dictionary<string, Dictionary<string, Product>> currentList, List<string> inputLine)
    {
        var name = inputLine[0];

        var type = inputLine[1];

        var price = double.Parse(inputLine[2]);

        var quantity = int.Parse(inputLine[3]);

        var currentProduct = new Product(name, price, quantity);

        if (!currentList.ContainsKey(type))
        {
            currentList[type] = new Dictionary<string, Product>();
        }

        currentList[type][name] = currentProduct;
    }
}

