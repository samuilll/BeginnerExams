using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice01
{
    class HousePrice01
    {
        static void Main(string[] args)
        {
            var littleRoomArea = double.Parse(Console.ReadLine());
            var kitchenArea = double.Parse(Console.ReadLine());
            var squareMetrePrice = double.Parse(Console.ReadLine());
            var bathArea = littleRoomArea / 2.0;
            var secondRoomArea = littleRoomArea + littleRoomArea / 10.0;
            var thirdRoomArea = secondRoomArea + secondRoomArea / 10.0;
            double houseArea = littleRoomArea + kitchenArea + bathArea + secondRoomArea + thirdRoomArea;
            houseArea = houseArea + houseArea / 20.0;
            double housePrice = houseArea * squareMetrePrice;
            Console.WriteLine("{0:f2}",housePrice);
        }
    }
}
