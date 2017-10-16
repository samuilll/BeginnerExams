using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Task04
    {
        static void Main(string[] args)
        {

            int NchosenFlaps = int.Parse(Console.ReadLine());

            double Mdisctanceper1000Flaps = double.Parse(Console.ReadLine());

            int Penduranceinflaps = int.Parse(Console.ReadLine());

            int restsinSeconds = NchosenFlaps / Penduranceinflaps*5;

            double distance = NchosenFlaps / 1000*Mdisctanceper1000Flaps;

            double time = NchosenFlaps / 100.0 + restsinSeconds;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{time} s.");

        }
    }
}
