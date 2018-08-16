using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task02MaxMethod
    {
        static void Main(string[] args)
        {

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int currentMax = GetTheMaxOfTwoNumbers(a,b);

        int max = GetTheMaxOfTwoNumbers(currentMax, c);

        Console.WriteLine(max);


    }

    private static int GetTheMaxOfTwoNumbers(int a, int b)
    {
        if (a>b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}

