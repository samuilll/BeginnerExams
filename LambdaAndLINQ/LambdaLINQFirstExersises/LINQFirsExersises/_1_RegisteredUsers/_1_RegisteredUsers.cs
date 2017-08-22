using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


    class _1_RegisteredUsers
    {
        static void Main(string[] args)
        {

        var register = new Dictionary<string, DateTime>();

        var nameAndData = Console.ReadLine()
            .Split(new char[] {'-','>',' '}, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        while (nameAndData[0]!="end")
        {
            var name = nameAndData[0];

            var time = DateTime.ParseExact(nameAndData[1], "dd/MM/yyyy",CultureInfo.InvariantCulture);

            register[name] = time;

            nameAndData = Console.ReadLine()
           .Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .ToArray();
        }

        var result = register
            .Reverse()
            .OrderBy(n => n.Value)
            .Take(5)
            .OrderByDescending(n => n.Value)
       //     .Reverse()
           .ToDictionary(n=>n.Key,n => n.Value) ;

        foreach (var pair in result)
        {
            Console.WriteLine("{0}",pair.Key);
        }
    }


    }

