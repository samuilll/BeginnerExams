using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctList01
{
    class DistinctList01
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).
               ToList();

           var arr = new int[numbers.Count];

          //  var counter = 0;

          

            for (int i = 0; i < numbers.Count; i++)
            {               
                
                for (int j = i+1; j < numbers.Count; j++)
                {
                    if (numbers[i]==numbers[j])
                    {
                        numbers.RemoveAt(j);
                        j--;
                    }
                }
            }

           

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
