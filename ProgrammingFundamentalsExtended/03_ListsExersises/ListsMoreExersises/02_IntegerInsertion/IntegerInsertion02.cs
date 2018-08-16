using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerInsertion02
{
    class IntegerInsertion02
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse).
              ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                var index = GetTheIndex(input);

                var inputnumber = GetTheIntValue(input);

                numbers.Insert(index, inputnumber);

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static int GetTheIntValue(string input)
        {
            return int.Parse(input);
        }

        private static int GetTheIndex(string input)
        {
            return int.Parse(input[0].ToString());
        }
    }
}
