using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sale
{
    public string Town { get; set; }

    public string Product { get; set; }

    public double Price { get; set; }

    public double Quantity { get; set; }

}
class _7_SalesReport
{
    static void Main(string[] args)
    {
        var salesNumber = int.Parse(Console.ReadLine());

        var salesDict = new SortedDictionary<string, double>();

        for (int i = 0; i < salesNumber; i++)
        {
            CalcuteTheSales(salesDict);
        }

        foreach (var townProfit in salesDict)
        {
            Console.WriteLine($"{townProfit.Key} -> {townProfit.Value:f2}");
        }
    }

    private static void CalcuteTheSales(SortedDictionary<string, double> salesDict)
    {
        var sale = new Sale();

        var input = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

        sale.Town = input[0];
        sale.Product = input[1];
        sale.Price = double.Parse(input[2]);
        sale.Quantity = double.Parse(input[3]);

        var Money = sale.Price * sale.Quantity;

        if (!salesDict.ContainsKey(sale.Town))
        {
            salesDict[sale.Town] = 0;
        }
        salesDict[sale.Town] += Money;

    }
}

