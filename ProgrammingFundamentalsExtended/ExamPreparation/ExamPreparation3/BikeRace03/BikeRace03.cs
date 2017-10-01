using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace03
{
    class BikeRace03
    {
        static void Main(string[] args)
        {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();
            double[] juniorPrices = new double[] { 5.50, 8, 12.25, 20 };
            double[] seniorPrices = new double[] { 7, 9.50, 13.75, 21.50 };
            var profit = 0.0;
            if (juniors + seniors < 50)
            {
                switch (trace)
                {
                    case "trail": profit = juniors * juniorPrices[0] + seniors * seniorPrices[0]; break;
                    case "cross-country": profit = juniors * juniorPrices[1] + seniors * seniorPrices[1]; break;
                    case "downhill": profit = juniors * juniorPrices[2] + seniors * seniorPrices[2]; break;
                    case "road": profit = juniors * juniorPrices[3] + seniors * seniorPrices[3]; break;
                }
            }
            else
            {
                switch (trace)
                {
                    case "trail": profit = juniors * juniorPrices[0]  + seniors * seniorPrices[0] ; break;
                    case "cross-country": profit = juniors * juniorPrices[1] * 3 / 4 + seniors * seniorPrices[1] * 3 / 4; break;
                    case "downhill": profit = juniors * juniorPrices[2]  + seniors * seniorPrices[2]; break;
                    case "road": profit = juniors * juniorPrices[3]  + seniors * seniorPrices[3]; break;
                }

            }
            profit = profit - profit / 20.0;
            Console.WriteLine("{0:f2}",profit);

        }
    }
}
