using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task04NumbersInReversedOrder
    {
        static void Main(string[] args)
        {

        decimal number = decimal.Parse(Console.ReadLine());

        Console.WriteLine(ReverseTheNumber(number));
        }

    private static string ReverseTheNumber(decimal number)
    {

        string stringNumber = number.ToString();

        StringBuilder result = new StringBuilder();

        for (int i = stringNumber.Length-1;i>=0; i--)
        {
            result.Append(stringNumber[i]);
        }

        return result.ToString();
    }
}

