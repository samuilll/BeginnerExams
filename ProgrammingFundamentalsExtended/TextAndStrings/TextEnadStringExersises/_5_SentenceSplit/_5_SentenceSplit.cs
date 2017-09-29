using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_SentenceSplit
{
    class _5_SentenceSplit
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var delimiter = Console.ReadLine();

            var result = inputLine.Split(new string[] { delimiter }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Console.WriteLine($"[{string.Join(", ",result)}]");
        }
    }
}
