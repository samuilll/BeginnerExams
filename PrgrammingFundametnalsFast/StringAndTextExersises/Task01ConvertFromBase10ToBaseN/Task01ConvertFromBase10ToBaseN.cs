using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task01ConvertFromBase10ToBaseN
{
    class Task01ConvertFromBase10ToBaseN
    {
        static void Main(string[] args)
        {

            var nums = Console.ReadLine().Split(' ').ToArray();

            BigInteger number = BigInteger.Parse(nums[1]);

            int baseN = int.Parse(nums[0]);

            string resultNumber = string.Empty;

            if (baseN>=2 && baseN<=10)
            {
                while (number>0)
                {
                    var rem = number % baseN;

                    number /= baseN;

                    resultNumber += rem.ToString();
                }
            }

            Console.WriteLine(string.Join("", resultNumber.ToCharArray().Reverse()));
        }
    }
}
