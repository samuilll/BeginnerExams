using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfGivenElement11
{
    class CountOfGivenElement11
    {
        static void Main(string[] args)
        {
            double[] array =Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            double number = double.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > number)

                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
