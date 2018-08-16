using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _3_TravelCompany
{
    static void Main(string[] args)
    {
        // “{ city}:{ type}-{ capacity},{ type}        -{ capacity}…”
        var inputLine = Console.ReadLine().Split(':');

        var transportList = new Dictionary<string, Dictionary<string, int>>();



        while (inputLine[0] != "ready")
        {
            var city = inputLine[0];

            var vehicleCapasityPairs = inputLine[1].Split(',');

            AddTheInformation(transportList, city, vehicleCapasityPairs);

            inputLine = Console.ReadLine().Split(':');

        }

        inputLine = Console.ReadLine().Split(' ');

        while (inputLine[0] != "travel")
        {
            var city = inputLine[0];

            var people = int.Parse(inputLine[1]);

            var capacity = CalculateTheCapacityOfCity(transportList, city);

            if (capacity>=people)
            {
                Console.WriteLine($"{city} -> all {people} accommodated");
            }
            else
            {
                Console.WriteLine($"{city} -> all except {people-capacity} accommodated");
            }

            inputLine = Console.ReadLine().Split(' ');

        }
    }

    private static int CalculateTheCapacityOfCity(Dictionary<string, Dictionary<string, int>> transportList, string city)
    {
        var sum = 0;

        foreach (var vehicle in transportList[city].Keys)
        {
           sum+= transportList[city][vehicle];
        }
        return sum;
    }

    private static void AddTheInformation(Dictionary<string, Dictionary<string, int>> transportList, string city, string[] vehicleCapacityPairs)
    {
        if (!transportList.ContainsKey(city))
        {
            transportList[city] = new Dictionary<string, int>();
        }
        for (int i = 0; i < vehicleCapacityPairs.Length; i++)
        {
            var onePair = vehicleCapacityPairs[i].Split('-');

            var vehicle = onePair[0];

            var capacity = int.Parse(onePair[1]);

            transportList[city][vehicle] = capacity;
        }
    }
}

