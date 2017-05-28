using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncryption08
{
    class StringEncryption08
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            string[] array = new string[N];
            for (int i = 0; i < N; i++)
            {
                var letter = char.Parse(Console.ReadLine());
                array[i] = (Encrypt(letter));

            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
        static string Encrypt(char letter)
        {
            var code = Convert.ToInt32(letter);
            var lastdigit = code % 10;
            var firstdigit = 0;
            for (int i = 0; ; i++)
            {
                firstdigit = code % 10;
                if (code / 10 != 0) code = code / 10;
                else break;
            }
            string Enc = Convert.ToString(firstdigit) + Convert.ToString(lastdigit);
            char firstletter = Convert.ToChar(letter + lastdigit);
            char lastletter = Convert.ToChar(letter - firstdigit);
            Enc = firstletter + Enc + lastletter;
            return Enc;

        }
    }
}
