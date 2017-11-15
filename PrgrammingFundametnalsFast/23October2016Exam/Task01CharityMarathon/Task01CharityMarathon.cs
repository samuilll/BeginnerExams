using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task01CharityMarathon
    {
        static void Main(string[] args)
        {
        long days = long.Parse(Console.ReadLine());
        long runners = long.Parse(Console.ReadLine());
        long lapsNumber = long.Parse(Console.ReadLine());
        long lapLength = long.Parse(Console.ReadLine());
        long trackCapacity = long.Parse(Console.ReadLine());
        decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

        long realRunners = trackCapacity*days >= runners ? runners: trackCapacity*days;

        decimal oneRunnerMeters = lapsNumber * lapLength;

        decimal allRunnerKilometers = (decimal)0.001*(oneRunnerMeters * realRunners);

        decimal allMoney = (decimal)allRunnerKilometers * moneyPerKilometer;

        Console.WriteLine($"Money raised: {allMoney:f2}");

    }
}

//Marathon day count will be an longeger in the range[0 … 365]
//Runner count will be an longeger in the range[0 … 2, 147, 483, 647]
//Average number of laps will be an longeger in the range[0 … 100]
//Lap length will be an longeger in the range[0 … 2, 147, 483, 647]
//Track capacity will be an longeger in the range[0 … 1000]
//Money per kilometer will all be a floating polong number