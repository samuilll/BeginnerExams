using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial2
{
    class Trial2
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 4, 7,6,7,6 };

            //                            11,12,12


            numbers.RemoveAt(1);

            Console.WriteLine(string.Join(" ",numbers));
            numbers.RemoveAt(1);
            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
