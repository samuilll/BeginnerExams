using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_OddLines
{
    class _1_OddLines
    {
        static void Main(string[] args)
        {

            var lines = File.ReadAllLines("ole.txt");

            Console.WriteLine(lines.Length);

            //   var newtext = new List<string>();

            //for (int i = 1; i < lines.Length; i += 2)
            //{
            //    File.AppendAllText("olele.txt", lines[i]+ Environment.NewLine);
            //}

      //      File.WriteAllLines("olele.txt", newtext);

            //-------------------new
        }
    }
}
