using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumAfterExtraction03
{
    class EqualSumAfterExtraction03
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).
                ToList();

            var secondList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).
                ToList();

            var thirdList = new List<int>();



            for (int i = 0; i < secondList.Count; i++)
            {

                if (!firstList.Contains(secondList[i]))
                {
                    thirdList.Add(secondList[i]);
                }

            }

            var sum1 = firstList.Sum();
            var sum2 = thirdList.Sum();

            if (sum1==sum2)
            {
                Console.WriteLine($"Yes. Sum: {sum1}");
            }

            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sum1-sum2)}");
            }
        }
    }
}
