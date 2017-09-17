using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMethod02
{
    class MinMethod02
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());
            var FirstMin = MinValue(number1, number2);
            var EndMin = MinValue(FirstMin, number3);
            Console.WriteLine(EndMin);

        }
        static int MinValue(int a, int b)
        {
            if (a > b) return b;
            else return a;
        }
    }
}
