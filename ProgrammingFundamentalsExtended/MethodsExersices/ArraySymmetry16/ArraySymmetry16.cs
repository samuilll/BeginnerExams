using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry16
{
    class ArraySymmetry16
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split();

            var check = true;

            for (int i = 1; i <= words.Length / 2; i++)
            {
                if (words[i-1] != words[words.Length - i])
                {
                    check = false;

                    break;
                }
            }

            if (check)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

