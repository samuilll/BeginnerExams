using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;



class Trial
{
    static void Main(string[] args)
    {


        Console.WriteLine(0 % 3);
        int coundOfSites = int.Parse(Console.ReadLine());

        BigInteger securityKey = BigInteger.Parse(Console.ReadLine());

        decimal sum = 0;

        var data = new List<string>();

        for (int i = 0; i < coundOfSites; i++)
        {
            var input = Console.ReadLine()
                       .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                       .ToArray();

            var siteName = input[0];

            data.Add(siteName);

            decimal visits = decimal.Parse(input[1]);

            decimal pricePerVisit = decimal.Parse(input[2]);

            var currentLoss = visits * pricePerVisit;

            sum += currentLoss;
        }

        // BigInteger token =(BigInteger)Math.Pow(securityKey, data.Count);

        BigInteger token = TakeThePow(securityKey, data.Count);

        foreach (var site in data)
        {
            Console.WriteLine($"{site}");
        }

        Console.WriteLine($"Total Loss: {sum:f20}");

        Console.WriteLine($"Security Token: {token}");
    }

    private static BigInteger TakeThePow(BigInteger securityKey, int count)
    {
        BigInteger result = 1;

        for (int i = 0; i < count; i++)
        {
            result = result * securityKey;
        }

        return result;
    }
}

