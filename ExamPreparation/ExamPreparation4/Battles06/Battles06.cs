using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles06
{
    class Battles06
    {
        static void Main(string[] args)
        {
            int firstPlayerPok = int.Parse(Console.ReadLine());
            int secondPlayerPok = int.Parse(Console.ReadLine());
            int maxBattlesCount = int.Parse(Console.ReadLine());

            var check = true;

            var battles = 0;

            for (int i = 1; i <= firstPlayerPok; i++)
            {
                for (int j = 1; j <= secondPlayerPok; j++)
                {
                    Console.Write("({0} <-> {1}) ",i,j);
                    battles++;
                    if (battles == maxBattlesCount)
                    {
                        check = false;
                        break;
                    }
                   
                }
                if (!check) break;
            }


        }
    }
}
