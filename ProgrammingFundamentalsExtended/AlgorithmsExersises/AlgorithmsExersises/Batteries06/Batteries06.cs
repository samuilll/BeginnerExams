using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batteries06
{
    class Batteries06
    {
        static void Main(string[] args)
        {
            var capacities = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToArray();

            var perHours = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(double.Parse)
              .ToArray();

            var workHours = int.Parse(Console.ReadLine());

            for (int i = 0; i < capacities.Length; i++)
            {
                bool check = IfTheBatteryIsAlive(capacities[i], perHours[i], workHours);

                if (check)
                {
                    var restedmAH = CalculateTheRestedMah(capacities[i], perHours[i], workHours);

                    var percentage = restedmAH / capacities[i] * 100;

                    Console.WriteLine($"Battery {i+1}: {restedmAH:f2} mAh ({percentage:f2})%");
                }

                else
                {
                    var lastedHours = CalculateTheRestedMah(capacities[i], perHours[i], workHours);

                    Console.WriteLine($"Battery {i+1}: dead (lasted {lastedHours} hours)");
                }

            }



        }

        private static bool IfTheBatteryIsAlive(double capasity, double perHour, int workHours)
        {
            if ((capasity - (perHour * workHours)) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static double CalculateTheRestedMah(double capasity, double perHour, int workHours)
        {
            if ((capasity - (perHour * workHours))>=0)
            {
                return capasity - (perHour * workHours);
            }
            else
            {
                return Math.Ceiling(capasity / perHour);
            }
           
        }
    }
}
