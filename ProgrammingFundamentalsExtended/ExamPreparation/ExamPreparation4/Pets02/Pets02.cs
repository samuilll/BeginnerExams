using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets02
{
    class Pets02
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var foodKilos = int.Parse(Console.ReadLine());
            var dogFood = double.Parse(Console.ReadLine());
            var catFood = double.Parse(Console.ReadLine());
            var tortoisFood = double.Parse(Console.ReadLine());

            var necessaryFood = dogFood*days + catFood*days+ tortoisFood*0.001 * days;

            if (necessaryFood<=foodKilos)

                Console.WriteLine("{0} kilos of food left.",Math.Floor(foodKilos-necessaryFood));

            else

                Console.WriteLine("{0} more kilos of food are needed.",Math.Ceiling(necessaryFood-foodKilos));
        }
    }
}
