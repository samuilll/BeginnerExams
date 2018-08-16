using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharRotation05
{
    class CharRotation05
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string newword = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)

                    newword += (char)(word[i] - array[i]);
                else

                    newword += (char)(word[i] + array[i]);
            }
            Console.WriteLine(newword);
        }
    }
}
