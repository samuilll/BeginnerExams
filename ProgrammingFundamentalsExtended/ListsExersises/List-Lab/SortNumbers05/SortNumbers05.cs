using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers05
{
    class SortNumbers05
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(decimal.Parse)
               .ToList();

            numbers.Sort();

            Console.WriteLine(string.Join(" <= ",numbers));
        }
    }
}
