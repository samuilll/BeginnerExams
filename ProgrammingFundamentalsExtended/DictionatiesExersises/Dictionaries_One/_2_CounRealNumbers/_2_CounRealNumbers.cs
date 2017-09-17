using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CounRealNumbers
{
    class _2_CounRealNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var sortedNumbers =new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!sortedNumbers.ContainsKey(number))
                {
                    sortedNumbers[number] = 1;
                }
                else
                {
                    sortedNumbers[number] += 1;
                }
            }

            foreach (var kvp in sortedNumbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
