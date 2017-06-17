using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial3
{
    class Trial3
    {
        static void Main(string[] args)
        {
            //int[] array = Console.ReadLine()
            //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();


            ////string[] text = Console.ReadLine().Split(' ');

            ////string[] operatingString = new string[text.Length];

            ////operatingString[0] = text[text.Length - 1];


            //int count = 0;


            //for (int i = 0; i < array.Length; i++)
            //{

            //    if (array[i] % 2 != 0)

            //        count++;

            //}

            //Console.WriteLine(count);
            //var currentnumber = 1;
            var n = int.Parse(Console.ReadLine());
            var currentNumber = 1;


            for (int i = 1; ; i++)
            {
                for (int j = 0; j <i; j++)
                {
                    Console.Write("{0:D2} ",currentNumber);
                    currentNumber++;
                    if (currentNumber > n)
                    {
                        
                        break;
                    }
                }

                
                
               
                if (currentNumber > n) break;
                Console.WriteLine();
            }
            Console.WriteLine();

            //var i = 2;

            //while (currentnumber<=n)
            //{

            //    Console.WriteLine(currentnumber);
            //    currentnumber = 2 * currentnumber + 1;



            //}



            //int minValue = int.MaxValue;
            //int index = 0;

            //    double p = double.Parse(Console.ReadLine());

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] <= minValue)
            //    {
            //        minValue = array[i];
            //        index = i;
            //    }
            //}

            //Console.WriteLine(minValue);
        }
    }
}
