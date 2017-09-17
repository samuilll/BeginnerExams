using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords07
{
    class NumbersToWords07
    {
        static void Main(string[] args)
        {
            var howmanytimes = int.Parse(Console.ReadLine());
            for (int i = 0; i < howmanytimes; i++)
            {
                var num = int.Parse(Console.ReadLine());
                NumberToWord(num);
            }
           
        }
        static void NumberToWord (int number)
        {
            
      
            string[] hundrets = new string[] {"one-hundred","two-hundred","three-hundred","four-hundred","five-hundred"
              ,"six-hundred","seven-hundred","eight-hundred","nine-hundred"};

            string[] decimals = new string[] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string[] ones = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            string[] exepts=new string[] { "ten", "eleven", "twelve","thirteen", "fourteen", "fivteen", "sixteen",
                "seventeen", "eighteen", "nineteen" };

            if (number < -999) Console.WriteLine("too small");

            else if (number > -100 && number < 100) ;

            else if (number > 999) Console.WriteLine("too large");

            else if (number <= 999 && number >= -999)
            {
                if (number < 0) { number = Math.Abs(number); Console.Write("minus "); }
                var hundretss = number / 100;
                var decimalss = number % 100 / 10;
                var oness = number % 10;
                if (number % 100 == 0) Console.WriteLine(hundrets[number/100-1]);
                else if (number % 100 < 10) Console.WriteLine("{0} and {1}",hundrets[hundretss-1],ones[oness-1]);
               else if (number % 100 >= 10 && number % 100 < 20) Console.WriteLine("{0} and {1}",hundrets[hundretss-1],exepts[oness]);
                else if (number % 10 == 0) Console.WriteLine("{0} and {1}",hundrets[hundretss-1],decimals[decimalss-2]);
                else Console.WriteLine("{0} and {1} {2}", hundrets[hundretss - 1], decimals[decimalss - 2],ones[oness-1]);


            }
        }
    }
}
