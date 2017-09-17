using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombination06
{
    class MaxCombination06
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var stop = int.Parse(Console.ReadLine());
            var combNumber = 0;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    if (combNumber == stop) break;
                    Console.Write("<{0}-{1}>",i,j);
                    combNumber++;
                }
            }
            Console.WriteLine();
        }
    }
}
