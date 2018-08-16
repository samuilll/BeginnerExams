using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnString03
{
    class ReturnString03
    {
        static void Main(string[] args)
        {
            string Text = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            RepeatString(Text, number);
        }
        static void RepeatString(string text, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(text);
            }
            Console.WriteLine();
        }


    }
}
