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

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {

                array[i] = int.Parse(Console.ReadLine());

                if ( array[i]<0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
