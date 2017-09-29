using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics04
{
    class Logistics04
    {
        static void Main(string[] args)
        {
            var cargoCount = int.Parse(Console.ReadLine());
            var allTonnage = 0.0;
            var averagePrice = 0.0;
            var busTones = 0;
            var lorryTones = 0;
            var trainTones = 0;
            var allPrice = 0;
            for (int i = 0; i < cargoCount; i++)
          
            {
                var tonnage = int.Parse(Console.ReadLine());
                if (tonnage <= 3)
                {
                    busTones += tonnage;
                    allPrice = allPrice + tonnage * 200;
                    allTonnage += tonnage;
                }
                else if (tonnage <= 11)
                {
                    lorryTones += tonnage;
                    allPrice = allPrice + tonnage * 175;
                    allTonnage += tonnage;
                }
                else
                {
                    trainTones += tonnage;
                    allPrice = allPrice + tonnage * 120;
                    allTonnage += tonnage;
                }
            }
            averagePrice = allPrice / allTonnage;
            Console.WriteLine("{0:f2}",averagePrice);
            Console.WriteLine("{0:f2}%",busTones*100/allTonnage);
            Console.WriteLine("{0:f2}%", lorryTones * 100 / allTonnage);
            Console.WriteLine("{0:f2}%", trainTones * 100 / allTonnage);

        }
    }
}
