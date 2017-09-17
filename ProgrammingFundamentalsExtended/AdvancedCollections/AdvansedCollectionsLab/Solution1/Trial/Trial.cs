using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    class Trial
    {
        static void Main(string[] args)
        {
            var numbers = new double[] { 5.5, 4.4, 6.0, 8.9 };

            string word = $"{numbers[0]:f4}";

            string oneMore = string.Format("{0:f5}", numbers[3]);

            Console.WriteLine(word);

            Console.WriteLine(oneMore);

            var p = "heygoletsgo" + $"{numbers[2]:f6}";

            Console.WriteLine(p);
        }
    }
}
