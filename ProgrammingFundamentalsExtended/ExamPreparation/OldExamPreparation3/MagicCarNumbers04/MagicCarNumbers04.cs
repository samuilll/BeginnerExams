using System;

class MagicCarNumbers04
{
    static void Main(string[] args)
    {
        char[] Letters = new char[] { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        int[] Numbers = new int[] { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int d1 = 0; d1 < 10; d1++)
        {
            for (int d2 = 0; d2 < 10; d2++)
            {
                for (int num1 = 0; num1 < 10; num1++)
                {
                    for (int num2 = 0; num2 < 10; num2++)
                    {
                        if (((30 + 10 + Numbers[num1] + Numbers[num2] + 4 * d1) == n) && (d1 == d2))
                            count += 1;
                        else
                        {
                            if (30 + 10 + Numbers[num1] + Numbers[num2] + (d1 + 3 * d2) == n)
                                count += 1;
                            if (30 + 10 + Numbers[num1] + Numbers[num2] + (3 * d1 + d2) == n)
                                count += 1;
                            if ((30 + 10 + Numbers[num1] + Numbers[num2] + (2 * d1 + 2 * d2) == n))
                                count += 3;
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}

