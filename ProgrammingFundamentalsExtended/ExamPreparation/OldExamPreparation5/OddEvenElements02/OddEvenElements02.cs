using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenElements02
{
    class OddEvenElements02
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            CompleteTheOperations(numbers);




        }

        private static void CompleteTheOperations(double[] numbers)
        {
            string[] text = new string[6] { null, null, null, null, null, null };
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            var oddSum = 0.0;
            double evenMin = double.MaxValue;
            var evenMax = double.MinValue;
            var evenSum = 0.0;
            var check1 = false;
            var check2 = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (numbers[i] <= oddMin) oddMin = numbers[i];

                    if (numbers[i] >= oddMax) oddMax = numbers[i];

                    oddSum = oddSum + numbers[i];
                    check1 = true;
                }
                else
                {
                    if (numbers[i] <= evenMin) evenMin = numbers[i];

                    if (numbers[i] >= evenMax) evenMax = numbers[i];

                    evenSum = evenSum + numbers[i];
                    check2 = true;
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (check1) text[0] = oddSum.ToString(); else text[0] = "No";
                if (oddMin != double.MaxValue) text[1] = oddMin.ToString(); else text[1] = "No";
                if (oddMax != double.MinValue) text[2] = oddMax.ToString(); else text[2] = "No";
                if (check2) text[3] = evenSum.ToString(); else text[03] = "No";
                if (evenMin != double.MaxValue) text[4] = evenMin.ToString(); else text[4] = "No";
                if (evenMax != double.MinValue) text[5] = evenMax.ToString(); else text[5] = "No";
            }

            
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}"
                , text[0], text[1], text[2], text[3], text[4], text[5]);
        }
    }
}
