using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers05
{
    class SquareNumbers05
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            var resultList = new List<int>();

            numbers.Sort();

            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))

                    resultList.Add(numbers[i]);
            }

            Console.WriteLine(string.Join(" ",resultList));
        }
    }
}
