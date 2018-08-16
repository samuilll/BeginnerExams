using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Task03
    {
        static void Main(string[] args)
        {


            var beehivesList = Console.ReadLine()
                .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            var hornetsList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            for (int i = 0; i < beehivesList.Count; i++)
            {

                var currentPower = hornetsList.Sum();

                if (currentPower==0)
                {
                    break;
                }

                if (currentPower>beehivesList[i])
                {
                    beehivesList.RemoveAt(i);

                    i--;
                }
                else if (currentPower==beehivesList[i])
                {
                    beehivesList.RemoveAt(i);

                    i--;

                    hornetsList.RemoveAt(0);
                }
                else
                {
                    beehivesList[i] -= currentPower;

                    hornetsList.RemoveAt(0);
                }
            }

            if (beehivesList.Count>0)
            {
                Console.WriteLine(string.Join(" ",beehivesList));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornetsList));

            }
        }
    }
}
