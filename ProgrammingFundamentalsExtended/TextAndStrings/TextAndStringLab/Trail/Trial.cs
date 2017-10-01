using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trail
{
    class Trial
    {
        static void Main(string[] args)
        {
            var word = "prokracadobra";

                var result = word.ToCharArray().Reverse();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(string.Join("",result));

        }
    }
}
