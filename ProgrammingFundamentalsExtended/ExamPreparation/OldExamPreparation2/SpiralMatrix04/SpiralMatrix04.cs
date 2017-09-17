using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix04
{
    class SpiralMatrix04
    {

        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            char[,] array = new char[N, N];
            string name = Console.ReadLine();
            int count = 1;

            FullTheMatrixWithElement(array, '*');

            SpiraMatrix(array, N, name);

            var maxWeight = GetTheMaxWeightRow(array);

            var index = GetTheMaxRowIndex(array);

            Console.WriteLine($"{index} - {maxWeight}");






        }

        private static int GetTheMaxWeightRow(char[,] array)
        {
            var currentWeight = 0;
            var maxWeight = 0;
            for (int i = array.GetLength(0) - 1; i >= 0; i--)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (array[i, j] >= 'a' && array[i, j] <= 'z') currentWeight = (Convert.ToInt32(array[i, j] - 96)) * 10 + currentWeight;
                    if (array[i, j] >= 'A' && array[i, j] <= 'Z') currentWeight = (Convert.ToInt32(array[i, j] - 64)) * 10 + currentWeight;

                }

                if (currentWeight >= maxWeight) maxWeight = currentWeight;

                currentWeight = 0;

            }
            return maxWeight;
        }

        static void ShowTheMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void FullTheMatrixWithElement(char[,] matrix, char letter)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = letter;

                }

            }
        }
        static void SpiraMatrix(char[,] array, int N, string name)
        {
            var count = 0;

            var tours = 0;
            while (tours < N / 2)
            {
                for (int j = tours; j < N - tours; j++)
                {
                    array[0 + tours, j] = name[count];
                    count++;
                    if (count == name.Length) count = 0;
                }
                for (int i = 1 + tours; i < N - tours; i++)
                {
                    array[i, N - 1 - tours] = name[count];
                    count++;
                    if (count == name.Length) count = 0;
                }
                for (int i = N - 2 - tours; i >= 0 + tours; i--)
                {
                    array[N - 1 - tours, i] = name[count];
                    count++;
                    if (count == name.Length) count = 0;
                }
                for (int i = N - 2 - tours; i >= 1 + tours; i--)
                {
                    array[i, 0 + tours] = name[count];
                    count++;
                    if (count == name.Length) count = 0;
                }
                tours++;
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (array[i, j] == '*') array[i, j] = name[count];
                }
            }
        }
        private static int GetTheMaxRowIndex(char[,] array)
        {
            var currentWeight = 0;
            var maxWeight = 0;
            var maxIndex = 0;
            for (int i = array.GetLength(0) - 1; i >= 0; i--)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (array[i, j] >= 'a' && array[i, j] <= 'z') currentWeight = (Convert.ToInt32(array[i, j] - 96)) * 10 + currentWeight;
                    if (array[i, j] >= 'A' && array[i, j] <= 'Z') currentWeight = (Convert.ToInt32(array[i, j] - 64)) * 10 + currentWeight;

                }

                if (currentWeight >= maxWeight)
                {
                    maxWeight = currentWeight;
                    maxIndex = i;
                }
                currentWeight = 0;

            }
            return maxIndex;
        }

    }
}
