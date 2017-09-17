using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearListInHalf05
{
    class TearListInHalf05
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).
               ToList();

            var firstArr = new int[numbers.Count / 2];

            var secondArr = new int[numbers.Count / 2];

            var outputList = new List<int>();

            FullTheBothHalfs(numbers, firstArr, secondArr);

            TearTheSecondHalfInTheNewList(firstArr ,secondArr, outputList);

            

            Console.WriteLine(string.Join(" ", outputList));

        }

        private static void TearTheSecondHalfInTheNewList(int[] firstArr,int[] secondArr, List<int> outputList)
        {
            for (int i = 0; i < secondArr.Length; i++)
            {
                var number1 = secondArr[i] / 10;

                var number2 = secondArr[i] % 10;

                outputList.Add(number1);
                outputList.Add(firstArr[i]);
                outputList.Add(number2);

            }
        }

        private static void FullTheBothHalfs(List<int> numbers, int[] firstArr, int[] secondArr)
        {
            for (int i = 0,j=numbers.Count/2; j < numbers.Count; i++,j++)
            {
                firstArr[i] = numbers[i];

                secondArr[i] = numbers[j];
            }
        }
    }
}
