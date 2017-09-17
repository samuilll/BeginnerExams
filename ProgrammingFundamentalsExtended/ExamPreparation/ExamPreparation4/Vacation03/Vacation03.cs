using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation03
{
    class Vacation03
    {
        static void Main(string[] args)
        {
            int adultsNumber = int.Parse(Console.ReadLine());
            int studentsNumber = int.Parse(Console.ReadLine());
            int daysNumber = int.Parse(Console.ReadLine());
            string kindOfTransport = Console.ReadLine();

            double allPrice = 0.0;

            

            double[] adulst = { 24.99, 32.50, 42.99, 70.00 };

            double[] children = { 14.99, 28.50, 39.99, 50.00 };

            switch (kindOfTransport)
            {
                case "train":
                    if ((studentsNumber + adultsNumber) >= 50)

                    {
                        allPrice = adulst[0] * adultsNumber + studentsNumber * children[0]; break;
                    }
                    else
                        allPrice = 2 * adulst[0] * adultsNumber + 2 * studentsNumber * children[0]; break;


                case "bus": allPrice = 2 * adulst[1] * adultsNumber + 2 * studentsNumber * children[1]; break;
                case "boat": allPrice = 2 * adulst[2] * adultsNumber + 2 * studentsNumber * children[2]; break;
                case "airplane": allPrice = 2 * adulst[3] * adultsNumber + 2 * studentsNumber * children[3]; break;
                default:
                    break;
            }
            allPrice = allPrice + daysNumber * 82.99;

            allPrice = allPrice + allPrice * 0.1;

            Console.WriteLine("{0:f2}",allPrice);
        }
    }
}
