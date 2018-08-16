using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task07ExchangeVariableValues
    {
        static void Main(string[] args)
        {

        int a = 5;
        int b = 10;
        int temp = a;
        Console.WriteLine($"Before:\na = {a}\nb = {b}");
        a = b;
        b = temp;
        Console.WriteLine($"After:\na = {a}\nb = {b}");

    }
}

//Before:
//a = 5
//b = 10
//After:
//a = 10
//b = 5