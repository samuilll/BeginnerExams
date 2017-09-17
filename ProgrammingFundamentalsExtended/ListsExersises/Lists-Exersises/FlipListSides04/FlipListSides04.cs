using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipListSides04
{
    class FlipListSides04
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).
                ToList();

            for (int i = 1; i < (numbers.Count)/2; i++)
            {
                var operationNumber = numbers[i];

                numbers[i] = numbers[numbers.Count - i-1];

                numbers[numbers.Count - i-1] = operationNumber;

            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
