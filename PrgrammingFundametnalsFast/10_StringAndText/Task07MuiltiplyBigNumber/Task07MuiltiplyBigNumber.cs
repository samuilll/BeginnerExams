using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07MuiltiplyBigNumber
{
    class Task07MuiltiplyBigNumber
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();

            int secondNumber =int.Parse( Console.ReadLine());

            var built = new StringBuilder();

            int numberOnMind = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                var number = (int.Parse(firstNumber[i].ToString()) * secondNumber);
                
                    number += numberOnMind;

                built.Append((number % 10).ToString());

                if (number >= 10)
                {
                    numberOnMind = number / 10;
                }
                else
                {
                    numberOnMind = 0;
                }
            }

            if (numberOnMind!=0)
            {
                built.Append($"{numberOnMind}");
            }
            //    Console.WriteLine(string.Join("", built.ToString().ToCharArray().Reverse()));

            string result = string.Join("", built.ToString().ToCharArray().Reverse());

            built = new StringBuilder(result);

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '0')
                {
                    result = result.Remove(i, 1);

                    i--;
                }
                else
                {
                    break;
                }
            }
            if (result.Length!=0)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
