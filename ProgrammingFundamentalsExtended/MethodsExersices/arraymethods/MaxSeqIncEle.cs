using System;
class Task5
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9,  -4, -3, -2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,11,12 };
        int count = 1;
        int bestcount = 1;
        int end = 0;
        int bestend = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if ((arr[i] == arr[i + 1] - 1) && (i != arr.Length - 2))
            {
                count++;
                end = i + 1;

            }
            else if ((count != 1) || (i == arr.Length - 2))
            {
                if (count > bestcount)
                {
                    bestcount = count;
                    bestend = end;
                    if ((i == arr.Length - 2)&&((arr[i] == arr[i + 1] - 1)))
                    {
                        bestend++;
                        bestcount++;
                    }
                }

                end = 0;
                count = 1;
            }

        }
        bestend = Math.Max(end, bestend);
        bestcount = Math.Max(bestcount, count);

        for (int i = bestend - bestcount + 1; i <= bestend; i++)
        {
            Console.Write("{0} ", arr[i]);

        }
    }
}

