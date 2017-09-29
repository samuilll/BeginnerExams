using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnunionLists04
{
    class UnunionLists04
    {
        static void Main(string[] args)
        {
            var primalList = Console.ReadLine()
           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse).
           ToList();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currentList = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                ImplementThePrimalListChange(primalList, currentList);
              
            }

            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));

        }

        private static void ImplementThePrimalListChange(List<int> primalList, List<int> currentList)
        {
            for (int i = 0; i < currentList.Count; i++)
            {
                if (!primalList.Contains(currentList[i]))
                {
                    primalList.Add(currentList[i]);
                }
                else
                {
                    primalList.Remove(currentList[i]);
                }
            }
        }
    }
}
