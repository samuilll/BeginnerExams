using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altitude17
{
    class Altitude17
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split();

            long altitude = long.Parse(commands[0]);

            for (int i = 1; i < commands.Length-1; i+=2)
            {
                if (altitude <= 0)

                    break;
                if (commands[i] == "up")
                {
                    altitude += int.Parse(commands[i + 1]);
                }

                if (commands[i] == "down")
                {
                    altitude -= int.Parse(commands[i + 1]);
                }

                

            }

            if (altitude>0)
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
            else
            {
                Console.WriteLine("crashed");
            }
        }
    }
}
