    using System;
    using System.Linq;

    public class SequenceOfCommands_broken
    {

        public static void Main()
        {
            long sizeOfArray = long.Parse(Console.ReadLine());

        
    long[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            string[] command = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (!command[0].Equals("stop"))
            {
 

                if (command[0].Equals("add") ||
                    command[0].Equals("subtract") ||
                    command[0].Equals("multiply"))
                {
                    long firstArgument = long.Parse(command[1])-1;
                    long secondArgument = long.Parse(command[2]);

                    PerformAction(command[0],firstArgument,secondArgument,array);
                }
                else
                {
                    if (command[0]=="rshift")
                    {
                        array = ArrayShiftRight(array);
                    }
                    if (command[0] == "lshift")
                    {
                        array = ArrayShiftLeft(array);
                    }
                }

                PrlongArray(array);

                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }

        static void PerformAction(string action, long firstArgument, long secondArgument,long[] array)
        {
            long index = firstArgument;
            long value = secondArgument;

            switch (action)
            {
                case "multiply":
                    array[index] *= value;
                    break;
                case "add":
                    array[index] += value;
                    break;
                case "subtract":
                    array[index] -= value;
                    break;
                case "lshift":
                   array =  ArrayShiftLeft(array);
                    break;
                case "rshift":
                  array =  ArrayShiftRight(array);
                    break;
            }
        }

        private static long[] ArrayShiftRight(long[] array)
        {
            long[] currentShift = new long[array.Length];

            currentShift[0] = array[array.Length - 1];

            for (long i = 0; i < array.Length-1; i++)
            {
                currentShift[i + 1] = array[i];
            }

            return currentShift;
        }

        private static long[] ArrayShiftLeft(long[] array)
        {
            long[] currentShift = new long[array.Length];

            currentShift[currentShift.Length-1] = array[0];

            for (long i = 1; i < array.Length; i++)
            {
                currentShift[i-1] = array[i];
            }

            return currentShift;
        }

        private static void PrlongArray(long[] array)
        {
            for (long i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
