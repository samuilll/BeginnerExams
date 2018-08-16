using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    class Trial
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
.Select(int.Parse)
.ToArray();

            RotateTheArray(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void RotateTheArray(int[] numbers)
        {
            int endElement = numbers[numbers.Length - 1];

            int safe = numbers[0];

            int secondsafe = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                safe = numbers[i];  //3 2 4 1 

             //   secondsafe = numbers[i + 1];

                numbers[i + 1] = safe;
            }
        }
    }
}
