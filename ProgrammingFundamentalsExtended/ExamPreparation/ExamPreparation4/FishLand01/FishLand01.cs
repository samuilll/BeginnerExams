using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishLand01
{
    class FishLand01
    {
        static void Main(string[] args)
        {
            var skumPrice = double.Parse(Console.ReadLine());
            var cacaPrice = double.Parse(Console.ReadLine());
            var palamudKilos = double.Parse(Console.ReadLine());
            var safridKilos = double.Parse(Console.ReadLine());
            var midiKilos = double.Parse(Console.ReadLine());

            var palamudPrice =palamudKilos* (skumPrice + 60 * skumPrice / 100);
            var safridPrice = safridKilos*(cacaPrice + 80 * cacaPrice / 100);
            var midiPrice = midiKilos * 7.50;
            var necessaryMoney = palamudPrice + safridPrice + midiPrice;

            Console.WriteLine("{0:f2}",necessaryMoney);
        }
    }
}
