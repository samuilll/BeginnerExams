using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualToTheirElements02
{
    class EqualToTheirElements02
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] arr2 = new int[arr.Length];
            var count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == i)
                {
                    arr2[count] = arr[i];
                    count++;
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{arr2[i]} ");
            }

            Console.WriteLine();
        }
    }
}
