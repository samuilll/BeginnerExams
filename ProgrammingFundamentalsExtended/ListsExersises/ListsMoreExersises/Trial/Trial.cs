using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteStatistics05
{
    class NoteStatistics05
    {
        static void Main(string[] args)
        {
            //var primalList = Console.ReadLine()
            // .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            // .Select(int.Parse).
            // ToList();

            //Console.WriteLine(string.Join(" ",primalList));

            //primalList.Insert(2, 5);

            //Console.WriteLine(string.Join(" ", primalList));

            var text = new string[] { "abc", "fdgfdg", "dfdfdsf" };

            Console.WriteLine(string.Join(" ", text));

            text[0] = " haideee";

            Console.WriteLine(string.Join(" ", text));



        }
    }
}
