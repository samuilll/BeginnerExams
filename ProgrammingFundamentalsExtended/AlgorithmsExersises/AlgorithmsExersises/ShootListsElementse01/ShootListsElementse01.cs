using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootListsElementse01
{
    class ShootListsElementse01
    {
        static void Main(string[] args)
        {

            List<int> listCommands = new List<int>();

            var check1 = true;

            var lastOneShooted = int.MinValue;


            do
            {
                var command = Console.ReadLine();

                if (Int32.TryParse(command,  out int p))
                {
                    listCommands.Insert(0,int.Parse(command));
                }

                else if (command == "bang")
                {
                    if (listCommands.Count == 0)
                    {
                        Console.WriteLine("nobody left to shoot! last one was {0}",lastOneShooted);

                        check1 = false;

                        break;
                    }

                    else

                     lastOneShooted = RemoveTheEqualOrSmallerThanAverageListValue(listCommands);
                }
                else if (command == "stop")
                {
                    break;
                }

            } while (true);

            if (check1)
            {
                if (listCommands.Count>0)
                {
                    Console.WriteLine("survivors: {0}",string.Join(" ",listCommands));
                }
                else
                {
                    Console.WriteLine("you shot them all. last one was {0}",lastOneShooted);
                }
            }




        }

        private static int RemoveTheEqualOrSmallerThanAverageListValue(List<int> listCommands)
        {
            double average = AverageListValue(listCommands);

            var lastOne = 0;

            for (int i = 0; i < listCommands.Count; i++)
            {
                if (listCommands[i] <= average)
                {
                    Console.WriteLine("shot {0}",listCommands[i]);

                    lastOne = listCommands[i];

                    listCommands.Remove(listCommands[i]);

                    break;
                }
            }

            DecrementEveryElementByOne(listCommands);

            return lastOne;
        }

        private static void DecrementEveryElementByOne(List<int> listCommands)
        {
            for (int i = 0; i < listCommands.Count; i++)
            {
                listCommands[i] -= 1;
            }
        }

        private static double AverageListValue(List<int> listCommands)
        {
            double sum = 0;

            for (int i = 0; i < listCommands.Count; i++)
            {
                sum += listCommands[i];
            }

            return sum / listCommands.Count;
        }
    }
}
