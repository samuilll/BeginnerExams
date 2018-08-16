using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemElAtOddPoss01
{
    class RemElAtOddPoss01
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var output = new List<string>();

            for (int i = 1; i < words.Count; i+=2)
            {
                output.Add(words[i]);

            }

            Console.WriteLine(string.Join("",output));
        }
    }
}
