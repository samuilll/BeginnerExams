using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    class Trial
    {
        static void Main(string[] args)
        {
            var word = "asdthisasd";


            var built = new StringBuilder(word);

            Console.WriteLine(string.Join("///",built.ToString().ToCharArray()));

            built.Append(built[0]);

            built.Remove(0, 1);

            Console.WriteLine(built.ToString());

            var f = string.Empty;

            Console.WriteLine(f.Length);

            var rrr = new List<char> { 'a', 'a', 'b', 'c', 'c', 'c', 'c' };

            Console.WriteLine(rrr.Count(n=>n=='b'));

            Console.WriteLine(word.Skip(5).ToString());

        //    word = string.Join("",word.ToCharArray().Reverse());


           // Console.WriteLine(string.Join("",proba.Reverse()));

           Console.WriteLine(word.Replace("asd",string.Empty));

            var num = 3;

            var num2 = (double)num/ 2;

            Console.WriteLine(num2);
        }
    }
}
