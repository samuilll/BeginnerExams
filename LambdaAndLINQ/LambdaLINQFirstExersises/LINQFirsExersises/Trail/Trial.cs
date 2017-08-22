using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class Trial
    {
        static void Main(string[] args)
        {
        //    DateTime timeString = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",CultureInfo.InvariantCulture);

        //  DateTime time = DateTime.ParseExact(timeString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        var dict = new Dictionary<string, string>();

        dict["ivan"] ="vtori" ;
        dict["fert"] = "purvi";

        dict["iman"] = "veliki";

        //dict["gersh"] = 3;
        //dict["morg"] = 3;
        //dict["gobl"] = 3;
        //dict["fitr"] = 3;

        //   dict = dict.
        //      Where(n => n.Value >= 3)
        //   .ToDictionary(n => n.Key, n => n.Value);

       

        dict = dict.
             ToDictionary(n => n.Key + n.Value, n =>string.Empty);
        foreach (var pair in dict)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }


    }
}

