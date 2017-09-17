using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_CountSubstringOccurrences
{
    class _1_CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();

            var searchedString = Console.ReadLine().ToLower();

            var counter = 0;

            var index = -1;

            while (true)
            {

             index = input.IndexOf(searchedString,index+1);

                if (index==-1)
                {
                    break;
                }
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
