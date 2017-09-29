using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial2
{
    class Trial2
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 234 };
            var showTheArray = string.Join(", ", array);
            Console.WriteLine(showTheArray);

            //var N = int.Parse(Console.ReadLine());

            //int[] array = new int[N];

            //var sum = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());

            //        sum += array[i];
            //}

            //Console.WriteLine(sum);

            
        }
    }
}
