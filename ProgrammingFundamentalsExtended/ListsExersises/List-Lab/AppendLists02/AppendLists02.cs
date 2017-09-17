using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists02
{
    class AppendLists02
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split('|').ToList();

            var numbers = new List<string>();

            var result = new List<string>();

            for (int i = text.Count-1; i >=0; i--)
            {
                numbers = text[i].Split(' ').ToList();

                for (int j = 0; j < numbers.Count; j++)
                {
                    numbers[j] = numbers[j].Trim();
                }

                foreach (var number in numbers)
                {
                    if (number!="")
                    {
                         result.Add(number);
                    }
                   
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}