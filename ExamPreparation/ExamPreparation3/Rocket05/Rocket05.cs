using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket05
{
    class Rocket05
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            var side = (3*N-2)/2;
            var middle = 3*N - 2 * side - 2;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",new string('.',side),new string(' ',middle));
                side--;
                middle += 2;
            }

            side++;

            Console.WriteLine("{0}{1}{0}", new string('.', side), new string('*', middle));

            middle -= 2;
            for (int i = 0; i < 2*N; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', side), new string('\\', middle));
            }

            for (int i = 0; i < N/2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', side), new string('*', middle));
                middle += 2;
                side--;
            }


        }
    }
}
