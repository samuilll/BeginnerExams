using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestElement09
{
    class LargestElement09
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];

            int maxElement = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {

                array[i] = int.Parse(Console.ReadLine());

                if (maxElement<array[i])
                {
                    maxElement = array[i];
                }
            }

            Console.WriteLine(maxElement);
        }
    }
}
