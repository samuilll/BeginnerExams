using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndRev01
{
    class RemoveNegativesAndRev01
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);

                    i--;
                }
            }

            numbers.Reverse();

            if (numbers.Count == 0)

                Console.WriteLine("Empty");
            else
            {



                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }
}
