using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop02
{
    class FlowerShop02
    {
        static void Main(string[] args)
        {
            var magnoliaCount = int.Parse(Console.ReadLine());
            var hyacinthCount = int.Parse(Console.ReadLine());
            var roseCount = int.Parse(Console.ReadLine());
            var cactusCount = int.Parse(Console.ReadLine());
            var presentPrice = double.Parse(Console.ReadLine());
            double[] prices = new double[] { 3.25, 4.00, 3.50, 8 };
            double profit = magnoliaCount * prices[0] + hyacinthCount * prices[1] + roseCount * prices[2] + cactusCount * prices[3];
            profit = profit - profit / 20.0;
            if (profit>=presentPrice)
                Console.WriteLine("She is left with {0} leva.",Math.Floor(profit-presentPrice));
            else
                Console.WriteLine("She will have to borrow {0} leva.",Math.Ceiling(presentPrice-profit));
                    
            

        }
    }
}
