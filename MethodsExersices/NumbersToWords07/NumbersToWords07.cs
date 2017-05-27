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
            if (number < -999) Console.WriteLine("too small");
            else if (number > -100 && number < 100) ;
            else if (number > 999) Console.WriteLine("too large");
            else if (number <= 999 && number > -999)
            {
                if (number < 0) { number = Math.Abs(number); Console.Write("minus "); }
                switch (number / 100)
                {
                    case 1: Console.Write("one-hundred"); break;
                    case 2: Console.Write("two-hundred"); break;
                    case 3: Console.Write("three-hundred"); break;
                    case 4: Console.Write("four-hundred"); break;
                    case 5: Console.Write("five-hundred"); break;
                    case 6: Console.Write("six-hundred"); break;
                    case 7: Console.Write("seven-hundred"); break;
                    case 8: Console.Write("eight-hundred"); break;
                    case 9:
                        Console.Write("nine-hundred"); break;
                        defaut: break;
                }
                if (number % 100 == 0) Console.WriteLine();
                if (number % 100 < 20)
                {
                    switch (number % 100)
                    {
                        case 1: Console.WriteLine(" and one"); break;
                        case 2: Console.WriteLine(" and two"); break;
                        case 3: Console.WriteLine(" and three"); break;
                        case 4: Console.WriteLine(" and four"); break;
                        case 5: Console.WriteLine(" and five"); break;
                        case 6: Console.WriteLine(" and six"); break;
                        case 7: Console.WriteLine(" and seven"); break;
                        case 8: Console.WriteLine(" and eight"); break;
                        case 9: Console.WriteLine(" and nine"); break;
                        case 10:
                            Console.WriteLine(" and ten"); break;
                            defaut: break;
                    }
                    switch (number % 100)
                    {
                        case 11: Console.WriteLine(" and eleven"); break;
                        case 12: Console.WriteLine(" and twleve"); break;
                        case 13: Console.WriteLine(" and thirteen"); break;
                        case 14: Console.WriteLine(" and fourteen"); break;
                        case 15: Console.WriteLine(" and fifteen"); break;
                        case 16: Console.WriteLine(" and sixteen"); break;
                        case 17: Console.WriteLine(" and seventeen"); break;
                        case 18: Console.WriteLine(" and eighteen"); break;
                        case 19: Console.WriteLine(" and nineteen"); break;
                            defaut: break;
                    }
                }
                else
                {
                    switch (number % 100 / 10)
                    {

                        case 2: Console.Write(" and twenty"); break;
                        case 3: Console.Write(" and thirtu"); break;
                        case 4: Console.Write(" and fourty"); break;
                        case 5: Console.Write(" and fifty"); break;
                        case 6: Console.Write(" and sixty"); break;
                        case 7: Console.Write(" and seventy"); break;
                        case 8: Console.Write(" and eighty"); break;
                        case 9:
                            Console.Write(" and ninety"); break;
                            defaut: break;
                    }
                    if (number % 10 == 0) Console.WriteLine();


                    if (number % 10 != 0)
                    {

                        switch (number % 10)
                        {
                            case 1: Console.WriteLine(" one"); break;
                            case 2: Console.WriteLine(" two"); break;
                            case 3: Console.WriteLine(" three"); break;
                            case 4: Console.WriteLine(" four"); break;
                            case 5: Console.WriteLine(" five"); break;
                            case 6: Console.WriteLine(" six"); break;
                            case 7: Console.WriteLine(" seven"); break;
                            case 8: Console.WriteLine(" eight"); break;
                            case 9: Console.WriteLine(" nine"); break;
                        }
                    }
                }
            }
          
            

        }
    }
}
