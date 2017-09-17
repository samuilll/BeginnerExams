using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow03
{
    class Arrow03
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var width = 2 * n - 1;
            var middle = n;
            var side = (width - middle) / 2;

            Console.WriteLine("{0}{1}{0}",new string('.',side),new string('#',middle));

            middle -= 2;

            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', side), new string('.', middle));
            }

            side += 1;

            Console.WriteLine("{0}{1}{0}", new string('#', side), new string('.', middle));

            side = 1;
            middle = width - (2 * side + 2);

            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', side), new string('.', middle));
                side += 1;
                middle -= 2;
            }

            Console.WriteLine("{0}#{0}",new string('.',side));

        }
    }
}
