using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task02FromBaseNToBase10
{
    class Task02FromBaseNToBase10
    {
        static void Main(string[] args)
        {

            var nums = Console.ReadLine().Split(' ').ToArray();

            char[] digits = nums[1].ToCharArray().Reverse().ToArray();

            BigInteger baseN = BigInteger.Parse(nums[0]);

            string resultNumber = string.Empty;

            BigInteger number = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                number += BigInteger.Parse(digits[i].ToString()) * PowFunction(baseN, i);
            }

            Console.WriteLine(number);

        }

        private static BigInteger PowFunction(BigInteger baseN, int i)
        {
            BigInteger sum = baseN;

            if (i == 0)
            {
                return 1;
            }
        
            while (i > 1)
            {
                sum *= baseN;

                i--;
            }

            return sum;
          

        }
    }
}
