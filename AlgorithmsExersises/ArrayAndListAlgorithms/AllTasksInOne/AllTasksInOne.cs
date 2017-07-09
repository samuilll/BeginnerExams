using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTasksInOne
{
    class AllTasksInOne
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            // Task One

            var N = int.Parse(Console.ReadLine());

            //bool check = ContainsOrsNot(numbers, N);

            //if (check)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");

            //}

            //   Task Two

            //    var minValueElement = FindTheMinValueElement(numbers);

            //    Console.WriteLine(minValueElement);

            //    Task Three 

            //    ReverseTheList(numbers);

            //   Console.WriteLine(string.Join(" ", numbers));

            // Task Four

            //       BubbleSort(numbers);

            //       Console.WriteLine(string.Join(" ", numbers));

            // Task Five

            //  InsertionSort(numbers);

            //  Console.WriteLine(string.Join(" ", numbers));

            //   Task Six

            //   SortUsingAHelpfulList(numbers);

            // Task Seven

            OutputTheLargestThreeElementsInAnArray(numbers);

            ReverseTheList(numbers);

            for (int i = 0; i < N; i++)
            {
                Console.Write("{0} ",numbers[i]);
            }
        }

        private static void OutputTheLargestThreeElementsInAnArray(int[] numbers)
        {

            InsertionSort(numbers);        }

        private static void SortUsingAHelpfulList(int[] numbers)
        {
            var helpList = new List<int>();

            for (int firstIndex = 0; firstIndex < numbers.Length; firstIndex++)
            {
                var check = false;
                for (int secondIndex = 0; secondIndex < helpList.Count; secondIndex++)
                {

                    if (numbers[firstIndex] < helpList[secondIndex])
                    {
                        helpList.Insert(secondIndex, numbers[firstIndex]);

                        check = true;

                        break;
                    }

                }
                if (!check)
                {
                    helpList.Add(numbers[firstIndex]);
                }
            }

            Console.WriteLine(string.Join(" ", helpList));
        }

        private static void InsertionSort(int[] numbers)
        {
            for (int firstIndex = 1; firstIndex < numbers.Length; firstIndex++)
            {
                for (int secondIndex = firstIndex; secondIndex > 0; secondIndex--)
                {
                    if (numbers[secondIndex] < numbers[secondIndex - 1])
                    {
                        SwapTheElements(ref numbers[secondIndex], ref numbers[secondIndex - 1]);
                    }
                    else
                    {
                        break;
                    }

                }
            }
        }

        private static void BubbleSort(int[] numbers)
        {
            var check = true;
            while (check)
            {

                check = false;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        SwapTheElements(ref numbers[i], ref numbers[i + 1]);
                        check = true;
                    }
                }
            }
        }

        private static void ReverseTheList(int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                SwapTheElements(ref numbers[i], ref numbers[numbers.Length - 1 - i]);

            }
        }

        private static void SwapTheElements(ref int number1, ref int number2)
        {


            var temp = number1;

            number1 = number2;

            number2 = temp;
        }

        private static object FindTheMinValueElement(int[] numbers)
        {
            int minElement = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (minElement > numbers[i])
                {
                    minElement = numbers[i];
                }
            }


            return minElement;
        }

        private static bool ContainsOrsNot(int[] numbers, int n)
        {
            var check = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                {
                    check = true;
                    break;
                }
            }

            return check;
        }
    }
}