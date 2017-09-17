using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SumMinMax
{
    class _1_SumMinMax
    {
        static void Main(string[] args)
        {
            var numbsNumber = int.Parse(Console.ReadLine());

            var sequence = new int[numbsNumber];

            for (int i = 0; i < numbsNumber; i++)
            {
                sequence[i] = int.Parse(Console.ReadLine());
            }

            var sum = sequence.Sum();
            var min = sequence.Min();
            var max = sequence.Max();
            var average = sequence.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");

        }
    }
}
