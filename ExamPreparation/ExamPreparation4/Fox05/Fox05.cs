using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox05
{
    class Fox05
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int side = 1;
            int middle = 2*n+1-2*side;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}",new string('*',side),new string('-',middle));
                side++;
                middle -= 2;
            }
            side = n / 2;
            middle = 2 * n - 1 - 2 * side;
            for (int i = 0; i < n/3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', side), new string('*', middle));
                side++;
                middle -= 2;
            }

             side = 1;
             middle = 2 * n + 1 - 2 * side;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', side), new string('*', middle));
                side++;
                middle -= 2;
            }

        }
    }
}
