using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "123";
            string str2 = "abc";
            str1 = str2;
            int number = 12324;
            str1 = number.ToString();
            int p = Convert.ToInt32(str1);
            Console.WriteLine(p);
             var x = int.Parse("35435");
            Console.WriteLine(x);
        }
    }
}
