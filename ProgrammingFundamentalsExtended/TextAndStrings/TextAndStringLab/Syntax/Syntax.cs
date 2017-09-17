using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Syntax
{
    static void Main(string[] args)
    {

        var a = "hello";

        var b = "buebue";

        var c = "hello";

        Console.WriteLine(b.CompareTo(a));//----------------------------------

        Console.WriteLine(string.Compare(a,b,true));//Insensitive to capital or small letters

        Console.WriteLine(string.Compare(a, b, false));//Sensitive to capital or small letters


        b = a;

        Console.WriteLine(b);

        b = "ggg";

        Console.WriteLine(b);

        a = ChangeTheString(a);

        Console.WriteLine(a);

        for (int i = 0; i < 10; i++)
        {
            a += "go";
        }
        Console.WriteLine(a);

        Console.WriteLine();

        var result = string.Concat(a, b, c);//----------------------------------

        Console.WriteLine(result);

        Console.WriteLine();

        result = "I'm Happy to see you friend, because you are my best friend";

        var indexOfFriend = result.IndexOf("friend");

        Console.WriteLine(indexOfFriend);

        indexOfFriend = result.IndexOf("friend", 22);//search from pointed index

        Console.WriteLine(indexOfFriend);

        Console.WriteLine(result.LastIndexOf("friend", 15));//searching from back to front

        Console.WriteLine(result.Substring(10));//--------------------------------
        Console.WriteLine();
        Console.WriteLine(result.Substring(10,10));//--------------------------------
        Console.WriteLine( );

        Console.WriteLine(result.Replace("friend","wonderful friend"));//-------------------------

        result.Replace("friend", "wonderful friend");//---------IT DOESN'T CHANGE THE INITIAL STRING----YOU HAVE TO DO THIS:

            result = result.Replace("friend", "wonderful friend");//--------------IT CHANGES THE INITIAL TEXT!

        Console.WriteLine(result);

        Console.WriteLine();

        Console.WriteLine(result.Remove(5,15));//-----------------------------------remove from N elemnts from given Index




    }

    private static string ChangeTheString(string a)
    {
        a = "I'm Changed";

        return a;
    }
}

