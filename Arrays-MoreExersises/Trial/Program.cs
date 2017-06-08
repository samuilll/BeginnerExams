using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "(602)207-2544", "+03456765", "+345454545797987" };
            var sum = 0;
            string p = "1965g";
            Console.WriteLine(Int32.Parse(p[4]));

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (Convert.ToInt32(words[i][j]) >= 0 && Convert.ToInt32(words[i][j]) <= 9)
                        sum = sum + Convert.ToInt32(words[i][j]);
                }
                Console.WriteLine(sum);
            }

        }
    }
}

