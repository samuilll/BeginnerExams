using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last3ConsecEqual01
{
    class Last3ConsecEqual01
    {
        static void Main(string[] args)
        {
            String[] words = Console.ReadLine().Split(' ');
            var index = -1;

            var count = 0;

            for (int i = words.Length - 1; i > 0; i--)
            {

                if ((words[i] == words[i - 1]))
                {
                    count++;
                    if (count == 2) { index = i; break; }
                }
                else
                {
                    count = 0;
                }
            }

            if (index != -1)
                Console.WriteLine("{0} {0} {0}", words[index]);
        }
    }
}
