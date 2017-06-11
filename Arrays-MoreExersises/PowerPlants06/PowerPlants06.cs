using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlants06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plantsPower = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var days = 0;
            var seasons = 0;
            var checkInstrument = plantsPower.Length;

            while (PlantsAreAlive(plantsPower)==true)
            {

                if (days == checkInstrument)
                {
                    checkInstrument +=plantsPower.Length;
                    IncreaseAlivePlants(plantsPower);
                    seasons++;
                }

                Onedaypass(plantsPower, days);

        //      ShowTheGraphic(plantsPower,days);

                days++;

                
            }

            

            if (seasons!=1)
            {
                Console.WriteLine($"survived {days} days ({seasons} seasons)");
            }
            else
                Console.WriteLine($"survived {days} days ({seasons} season)");
        }

        private static bool PlantsAreAlive(int[] plantsPower)
        {
            bool aliveOrNot = false;
            for (int i = 0; i < plantsPower.Length; i++)
            {
                

                if (plantsPower[i] != 0)
                {
                    aliveOrNot = true;
                    break;
                }
               
            }
            return aliveOrNot;
        }

        private static void IncreaseAlivePlants(int[] plantsPower)
        {
            for (int i = 0; i < plantsPower.Length; i++)
            {
                if (plantsPower[i]!=0)
                {
                    plantsPower[i] += 1;
                }
            }
        }

        private static void ShowTheGraphic(int[] plantsPower,int days)
        {
            Console.Write($"Day {days} -> ");
            for (int i = 0; i < plantsPower.Length; i++)
            {
                Console.Write(plantsPower[i]+" ");
            }
            Console.WriteLine();
        }

        private static void Onedaypass(int[] plantsPower, int days)
        {
            for (int i = 0; i < plantsPower.Length; i++)
            {
                if (plantsPower[i]>0)
                {
                    plantsPower[i]--;
                }
                if ((days % plantsPower.Length == i) && plantsPower[i]>0)
                    plantsPower[i]++;
              
            }
        }
    }
}
