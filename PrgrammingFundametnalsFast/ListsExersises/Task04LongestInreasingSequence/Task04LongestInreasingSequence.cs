using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04LongestInreasingSequence
{
    class Task04LongestInreasingSequence
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

            int[] len = new int[numbers.Length];

            int[] prev = new int[numbers.Length];

            len[0] = 1;

            prev[0] = -1;

            int bestLength = 0;

            int bestIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                var check = false;

                for (int j = 0; j <i; j++)
                {
                    if (numbers[i]>numbers[j] && len[i]<len[j]+1 )
                    {
                        prev[i] = j;

                        len[i] = len[j] + 1;

                        check = true;

                        if (len[i]>bestLength)
                        {
                            bestLength = len[i];

                            bestIndex = i;
                        }
                    }
                }
                if (!check)
                {
                     len[i] = 1;
                    prev[i] = -1;
                }
                
            }

            //Console.WriteLine(string.Join(" ",len));
            //Console.WriteLine(string.Join(" ",prev));
            //Console.WriteLine($"{bestIndex} -> {bestLength}");

            List<int> result = new List<int>();

            
            while (bestIndex!=-1)
            {
                result.Add(numbers[bestIndex]);

                bestIndex = prev[bestIndex];
            }

            result.Reverse();

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
