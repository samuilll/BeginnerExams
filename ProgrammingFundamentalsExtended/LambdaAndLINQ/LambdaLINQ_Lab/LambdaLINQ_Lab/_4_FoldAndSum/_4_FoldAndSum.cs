using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FoldAndSum
{
    class _4_FoldAndSum
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var firstHalf = numbers
                .Take(numbers.Count / 4)
                .Reverse();

            var secondHalf = numbers
                .Skip(3 * numbers.Count / 4)
                .Take(numbers.Count / 4)
                .Reverse();

            var firstSequence = firstHalf
                .Concat(secondHalf)
                .ToList();

            var secondSequence = numbers
                .Skip(numbers.Count / 4)
                .Take(numbers.Count / 2)
                .ToList();

          //  Console.WriteLine(string.Join(" ",firstSequence));
          //  Console.WriteLine(string.Join(" ", secondSequence));

            var result = new List<int>();

            for (int i = 0; i < firstSequence.Count; i++)
            {
                result.Add(firstSequence[i] + secondSequence[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
