using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallisticTraining18
{
    class BallisticTraining18
    {
        static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions
                                .RemoveEmptyEntries).Select(int.Parse)
                                .ToArray();

            string[] commands = Console.ReadLine().Split();

            int xRocket = 0;
            int yRocket = 0;

            for (int i = 0; i < commands.Length-1; i+=2)
            {

                if (commands[i] == "up")
                {
                    yRocket += int.Parse(commands[i + 1]);
                }

                if (commands[i] == "down")
                {
                    yRocket -= int.Parse(commands[i + 1]);
                }

                if (commands[i] == "right")
                {
                    xRocket += int.Parse(commands[i + 1]);
                }

                if (commands[i] == "left")
                {
                    xRocket -= int.Parse(commands[i + 1]);
                }
            }

            if (xRocket == coordinates[0] && yRocket == coordinates[1])
            {
                Console.WriteLine($"firing at [{xRocket}, {yRocket}]\ngot 'em!");
            }
            else
            {
                Console.WriteLine($"firing at [{xRocket}, {yRocket}]\nbetter luck next time...");
            }
        }
    }
}
