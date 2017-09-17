using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trail
{
    class Trial
    {
        static void Main(string[] args)
        {

            //   var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string word = "aaaabbbbbdddddggg";

            var second = word.Distinct().ToArray();

            Console.WriteLine(second[1]);

            //Console.WriteLine(word);
            //Console.WriteLine(second);

            var words = new List<string> { "ivan","aseassn","vtsadaori","padeti"};


            Console.WriteLine(words.Min());
            ////var list = new List<int> { 1, 2, 3, 4, 5, 6, 8 };

            ////list = list
            ////    .Take(3)
            ////    .Select(n => n = 111)
            ////    .ToList();

            ////list = list.Where(n => n > list.Average()).ToList();

            ////var campersRegister = new Dictionary<Dictionary<string, int>, List<string>>();

            ////campersRegister["sasho", 3] = new List<string> { "haide", "de" };
            ////Console.WriteLine(string.Join(" ", list));

            //var one = new Dictionary<string, int>();

            //var two = new Dictionary<string, int>();

            //one["hello"] = 1;
            //one["before"] = 123;
            //one["hey"] = 12;
            //two["figurative"] = 45;
            //one["fuftire"] = 100;
            //one["figurrrrative"] = 300;
            //one["ggg"] = 1111;

            //one = one
            //    .Concat(two)
            //    .OrderBy(n => n.Value)
            //    .ToDictionary(n => n.Key, n => n.Value);

            ////one = one
            ////    Remove()

            //one = one
            //    .ToDictionary(n => n.Key, n => n.Value - 123);

            //Console.WriteLine(one.Count);

            ////     ChangeTheDictionary(one);

            //var keys = one
            //    .Select(n => n.Key)
            //    .ToArray();

            //for (int i = 0; i < keys.Length; i++)
            //{
            //   var key = keys[i];

            //    Console.WriteLine( $"{key}  {one[key]}");
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //for (int i = 0; i < keys.Length; i++)
            //{
            //    var key = keys[i];
            //    if (i<3)
            //    {
                   

            //        one[key] += 12334;
            //    }
               

            //    Console.WriteLine($"{key}  {one[key]}");
            //}


            ////        var hash = new List<int> { 1, 2, 3, 4, 4, 5, 6, 6 };

            ////        //  hash = Change(hash);

            ////        AnotherChange(hash);

            ////        foreach (var pair in one)
            ////        {
            ////            Console.WriteLine($"{pair.Key}  -  {pair.Value}");
            ////        }
            ////        Console.WriteLine();

            ////        Console.WriteLine(string.Join(" ", hash));

        }

        //    private static void AnotherChange(List<int> hash)
        //    {
        //        for (int i = 0; i < hash.Count; i++)
        //        {
        //            hash[i] += 1111;
        //        }
        //    }

        //    private static List<int> Change(List<int> hash)
        //    {
        //        hash = hash.Select(n => n + 1111).ToList();

        //        return hash;
        //    }

        //    private static void ChangeTheDictionary(Dictionary<string, int> one)
        //    {
        //        one = one.ToDictionary(n => n.Key, n => n.Value + 123);
        //    }
    }
}
