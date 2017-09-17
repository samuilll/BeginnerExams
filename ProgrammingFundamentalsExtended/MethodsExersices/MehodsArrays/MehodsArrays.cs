using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehodsArrays
{
    class MehodsArrays
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            FullTheArray(array);
            Console.WriteLine();
            var number = NumberOfMaxIncreasingConsecution(array);
            var index = IndexOfMaxIncreasingConsecution(array);
            Console.WriteLine(number);
            Console.WriteLine(index);
            Console.WriteLine();
            for (int i = index - number + 1; i <= index; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static int NumberOfMaxConsecutiveElements(int[] array)
        {
            var count = 1;
            var countmax = 0;
            var index = 0;
            var indexmax = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((array[i] == array[i + 1] - 1) && (i != array.Length - 2))
                {
                    count++;
                    index = i + 1;
                }
                else if ((array[i] == array[i + 1] - 1) && (i == array.Length - 2))
                {
                    count++;
                    index = i + 1;
                    if (countmax < count)
                    {
                        countmax = count;
                        indexmax = index;
                    }

                }
                else
                {
                    if (countmax < count)
                    {
                        countmax = count;
                        indexmax = index;
                    }
                    count = 1;
                    index = 0;
                }
            }
            return (countmax);

        }
        static int IndexOfLastElement(int[] array)
        {
            var count = 1;
            var countmax = 0;
            var index = 0;
            var indexmax = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((array[i] == array[i + 1] - 1) && (i != array.Length - 2))
                {
                    count++;
                    index = i + 1;
                }
                else if ((array[i] == array[i + 1] - 1) && (i == array.Length - 2))
                {
                    count++;
                    index = i + 1;
                    if (countmax < count)
                    {
                        countmax = count;
                        indexmax = index;
                    }

                }
                else
                {
                    if (countmax < count)
                    {
                        countmax = count;
                        indexmax = index;
                    }
                    count = 1;
                    index = 0;
                }
            }
            return (indexmax);

        }
        static void FullTheArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
        }
        static int NumberOfMaxIncreasingConsecution(int[] array)
        {
            var count = 1;
            var countmax = 0;
            var index = 0;
            var indexmax = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((array[i] < array[i + 1]) && (i != array.Length - 2))
                {
                    count++;
                    index = i + 1;
                }
                else if ((array[i] < array[i + 1]) && (i == array.Length - 2))
                {
                    count++;
                    index = i + 1;
                    if (countmax < count)
                    {
                        countmax = count;
                        indexmax = index;
                    }

                }
                else
                {
                    if (countmax < count)
                    {
                        countmax = count;
                        indexmax = index;
                    }
                    count = 1;
                    index = 0;
                }
            }
            return (countmax);


        }

        static int IndexOfMaxIncreasingConsecution(int[] array)
        {
            var count = 1;
            var countmax = 0;
            var index = 0;
            var indexmax = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((array[i] < array[i + 1]) && (i != array.Length - 2))
                {
                    count++;
                    index = i + 1;
                }
                else if ((array[i] < array[i + 1]) && (i == array.Length - 2))
                {
                    count++;
                    index = i + 1;
                    if (countmax < count)
                    {
                        countmax = count;
                        indexmax = index;
                    }

                }
                else
                {
                    if (countmax < count)
                    {
                        countmax = count;
                        indexmax = index;
                    }
                    count = 1;
                    index = 0;
                }
            }
            return (indexmax);


        }
    }
}
