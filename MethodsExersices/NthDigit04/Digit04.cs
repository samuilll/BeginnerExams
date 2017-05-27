using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigit04
{
    class Digit04
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            var digit = ReturnDigit(num, index);
            Console.WriteLine(digit);
            
        }
        static int ReturnDigit(long number, int index)
            {
            var digit = 0;
            for (int i = 0; i < index; i++)
            {
                 digit = Convert.ToInt32(number % 10);
                number = number / 10;
            }
            return digit;
        }
    }
}
