using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook03
{
    class Phonebook03
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            string currentName = Console.ReadLine();
            while (currentName != "done")
            {
               
                for (int i = 0; i < names.Length; i++)
                {
                    if (currentName==names[i])

                        Console.WriteLine("{0} -> {1}",names[i],phoneNumbers[i]);
                }

                currentName = Console.ReadLine();
            }
        }
    }
}
