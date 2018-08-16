using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers07
{
    class CountNumbers07
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
             .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToList();

            var output = new int[1001];

            for (int i = 0; i < numbers.Count; i++)
            {
                output[numbers[i]]++;
            }

            for (int i = 0; i < output.Length; i++)
            {
                if (output[i]!=0)

                Console.WriteLine($"{i} -> {output[i]}");
            }
        }
    }
}
