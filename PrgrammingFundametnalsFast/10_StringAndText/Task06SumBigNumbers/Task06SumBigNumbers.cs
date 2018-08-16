using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06SumBigNumbers
{
    class Task06SumBigNumbers
    {
        static void Main(string[] args)
        {

            string firstNumber = Console.ReadLine();

            string secondNumber = Console.ReadLine();

            var built = new StringBuilder();

            if (firstNumber.Length > secondNumber.Length)
            {
                for (long i = 0; i < firstNumber.Length - secondNumber.Length; i++)
                {
                    built.Append("0");
                }

                secondNumber = built.ToString() + secondNumber;
            }
            else
            {
                for (int i = 0; i < secondNumber.Length - firstNumber.Length; i++)
                {
                    built.Append("0");
                }

                firstNumber = built.ToString() + firstNumber;
            }

            built.Clear();

            var oneOnMind = false;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                var number = (int.Parse(firstNumber[i].ToString()) + int.Parse(secondNumber[i].ToString()));

                if (oneOnMind)
                {
                    number += 1;
                }

                built.Append((number % 10).ToString());

                if (number >= 10)
                {
                    oneOnMind = true;
                }
                else
                {
                    oneOnMind = false;
                }
            }

            if (oneOnMind)
            {
                built.Append("1");
            }

       //    Console.WriteLine(string.Join("", built.ToString().ToCharArray().Reverse()));

            string result = string.Join("", built.ToString().ToCharArray().Reverse());

            built = new StringBuilder(result);

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i]=='0')
                {
                    result =result.Remove(i, 1);

                    i--;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
