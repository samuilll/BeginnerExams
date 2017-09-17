using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    class Task07
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int K = int.Parse(Console.ReadLine());

            int[] array = new int[N];

            InputTheNumbersInTheArray(array);

            var index = GetirstIndexOfTheMaxSumSequence(array, K);

            for (int i =index ; i < index+K; i++)
            {
                Console.Write(array[i]+" ");
            }

            Console.WriteLine();


            // 6   3     12 3 4 2 3 45

        }

        private static int GetirstIndexOfTheMaxSumSequence(int[] array, int K)
        {
           

            var sum = 0;
            var maxSum = 0;
            var index = 0;

            for (int i = 0; i <= array.Length - K; i++)
            {

                for (int j = i; j < i + K; j++)
                {
                    sum += array[j];
                }

                if (maxSum < sum)

                {
                    maxSum = sum;
                    index = i;
                }
                Console.WriteLine(sum);
                Console.WriteLine();
                sum = 0;
            }
            return index;
        }

        private static void InputTheNumbersInTheArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
