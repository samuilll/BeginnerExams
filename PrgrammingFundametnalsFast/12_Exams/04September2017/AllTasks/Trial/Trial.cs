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
            var secondHalf = "abvgdhj";

            secondHalf = string.Join("", secondHalf.ToCharArray().Reverse());

            Console.WriteLine(secondHalf);

        }
    }
}
