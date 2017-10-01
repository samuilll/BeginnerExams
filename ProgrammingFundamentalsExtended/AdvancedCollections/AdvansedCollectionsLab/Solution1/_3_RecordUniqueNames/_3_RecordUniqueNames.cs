using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_RecordUniqueNames
{
    class _3_RecordUniqueNames
    {
        static void Main(string[] args)
        {
            var howManyNames = int.Parse(Console.ReadLine());

            var uniqueNames = new HashSet<string>();

            for (int i = 0; i < howManyNames; i++)
            {
                var name = Console.ReadLine();

                uniqueNames.Add(name);
            }

            Console.WriteLine(string.Join(Environment.NewLine,uniqueNames));
            //foreach (var name in uniqueNames)
            //{
            //    Console.WriteLine(name);
            //}
        }
    }
}
