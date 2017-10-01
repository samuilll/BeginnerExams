using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program//asdsakdjlksajdksajd
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());

            //var c = int.Parse(Console.ReadLine());
            //var d = int.Parse(Console.ReadLine());
            //Console.WriteLine("{0} {1} {2} {3}",a.ToString("D4"), b.ToString("D4"),c.ToString("D4"),d.ToString("D4"));
            Console.WriteLine("{0:f2}", a * 1.60934);

        }
    }
}
//1 mile == 1.60934 kilometers