using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task05BooleanVariable
    {
        static void Main(string[] args)
        {

        string trueOrFalse = Console.ReadLine();

        if (Convert.ToBoolean(trueOrFalse))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        }
    }

