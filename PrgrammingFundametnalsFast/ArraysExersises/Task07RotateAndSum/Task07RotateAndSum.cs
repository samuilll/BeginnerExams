using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task07RotateAndSum
{
    static void Main(string[] args)
    {

        int[] numbers = Console.ReadLine()
      .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
      .Select(int.Parse)
      .ToArray();


        //  Console.WriteLine(string.Join(" ",numbers));

        int rotates = int.Parse(Console.ReadLine());

        int[] sum = new int[numbers.Length];

        while (rotates-- > 0)
        {
            int[] rotatedArray = RotatingFunction(numbers);

            sum = SumTheTwoArrays(rotatedArray, sum);

            numbers = rotatedArray;

        }

        Console.WriteLine(string.Join(" ", sum));


    }

    private static int[] SumTheTwoArrays(int[] rotatedArray, int[] sum)
    {
        for (int i = 0; i < sum.Length; i++)
        {
            sum[i] = sum[i] + rotatedArray[i];
        }

        return sum;
    }

    private static int[] RotatingFunction(int[] numbers)
    {
        int[] rotatedArray = new int[numbers.Length];

        rotatedArray[0] = numbers[numbers.Length - 1];

        for (int i = 1; i < numbers.Length; i++)
        {
            rotatedArray[i] = numbers[i - 1];
        }

     //   Console.WriteLine(string.Join(" ", rotatedArray));

        return rotatedArray;
    }
}

