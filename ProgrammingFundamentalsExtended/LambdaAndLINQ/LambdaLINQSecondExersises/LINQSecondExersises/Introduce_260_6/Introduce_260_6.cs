using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduce_260_6
{
    class Introduce_260_6
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var help = new int[numbers.Length].Select(n => n = 1).ToArray();

            var prev = new int[numbers.Length];

            var max = 0;

            var lastIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    if (numbers[i]>numbers[j] && help[j]+1>help[i])
                    {
                        help[i] = help[j]+1;
                        prev[i] = numbers[j];
                    }
                }
                if (max<help[i])
                {
                    max = help[i];
                    lastIndex = i;
                }
            }

            var result = new List<int>();

            result.Add(numbers[lastIndex]);

            var prevNumber = prev[lastIndex];

            for (int i = lastIndex; i > 0; i--)
            {

                if (numbers[i] == prevNumber)
                {
                    result.Add(numbers[i]);

                    prevNumber = prev[i];
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine();

            Console.WriteLine(string.Join(" ", help));
            Console.WriteLine();

            Console.WriteLine(string.Join(" ", prev));
            Console.WriteLine();

            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
            Console.WriteLine();


        }
    }
}
