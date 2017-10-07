using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task03FoldAndSum
    {
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

        int k = numbers.Length / 4;

        int[] foldedArrayFirst = new int[2 * k];

        int[] foldedArraySecond = new int[2 * k];

        int j = 0;

        for (int i = k - 1; i >= 0; i--, j++)
        {
            foldedArrayFirst[j] = numbers[i];
        }

        for (int i = numbers.Length - 1; i > numbers.Length - k-1; i--)
        {
            foldedArrayFirst[j++] = numbers[i];
        }

        for (int i = k, f = 0; i < 3 * k; i++)
        {
            foldedArraySecond[f++] = numbers[i];
        }

        for (int i = 0; i < foldedArrayFirst.Length; i++)
        {
            Console.Write($"{foldedArrayFirst[i]+foldedArraySecond[i]} ");
        }

        //Console.WriteLine(string.Join(" ", foldedArrayFirst));
        //Console.WriteLine(string.Join(" ", foldedArraySecond));

        Console.WriteLine();


    }
}

