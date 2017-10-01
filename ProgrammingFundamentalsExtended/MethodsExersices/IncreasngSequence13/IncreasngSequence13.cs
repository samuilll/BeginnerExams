using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasngSequence13
{
    class IncreasngSequence13
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();

            var check = true;

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] != array[i + 1])

                {
                    check = false;
                    break;
                }
            }

            if (check)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
