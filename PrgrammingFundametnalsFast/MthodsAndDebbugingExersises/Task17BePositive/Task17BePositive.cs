﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task17BePositive
{
    static void Main(string[] args)
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            int[] input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var numbers = new List<int>();

            for (int j = 0; j < input.Length ; j++)
            {
                int currentNum = input[j];

                if (currentNum >= 0)
                {
                    numbers.Add(currentNum);
                }
                else
                {
                    if (j!=input.Length-1)
                    {
                        currentNum += input[j + 1];

                        if (currentNum >= 0)
                        {
                            numbers.Add(currentNum);
                        }
                        j++;
                    }
                }
            }

            if (numbers.Count==0)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                Console.WriteLine(string.Join(" ",numbers));
            }
        }


    }
}

