using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Largest3Numbers
{       
    class _1_Largest3Numbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var selected = numbers.OrderByDescending(n => n)
                .Take(3)
                .ToArray();

            Console.WriteLine(string.Join(" ",selected));
        }
    }
}
