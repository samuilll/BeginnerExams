using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial
{
    class Trial
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("name\":{0}",Math.PI);

            //var nums = new List<int> { 6, 7, 5, 4 };

            //Console.WriteLine(string.Join(", ",nums));

            //Console.WriteLine("{{{0}}}",2);

            //var list = new List<int>();

            //Console.WriteLine(list.Count);

            //var hop = new Dictionary<string, string>
            //{
            //    ["ivan"] = "petyr",
            //    ["local"] = "dynamic"
            //};

            //Console.WriteLine(hop.Last().Key);
            //foreach (var item in hop)
            //{
            //    Console.WriteLine($"{item.Value}");
            //}

            //Console.WriteLine(string.Join("",hop.Keys));


            var  p = "BBBBoko";

            p = p.ToLower();

          var   q = p.Replace(p[0],char.ToUpper(p[0]));

            Console.WriteLine(p);
        }

      


    }
}
