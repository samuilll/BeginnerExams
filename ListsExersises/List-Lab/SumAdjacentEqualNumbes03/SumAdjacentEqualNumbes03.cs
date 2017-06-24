using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbes03
{
    class SumAdjacentEqualNumbes03
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

           

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] = 2 * numbers[i];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }


            Console.Write(String.Join(" ", numbers));

            Console.WriteLine();



        }
    }
}
