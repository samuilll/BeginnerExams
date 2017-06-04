using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Task18
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            int[,] array = new int[N, N];
            int count = 1;
            FullTheMatrixWithElement(array, 0);


            SpiraMatrix(array, N);

            
            ShowTheMatrix(array);

        }
        static void ShowTheMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString("D2")+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void FullTheMatrixWithElement(int[,] matrix, int letter)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = letter;

                }

            }
        }
        static void SpiraMatrix(int[,] array,int N)
        {
            var count = 1;
           
            var turns = 0;
            while (turns < N / 2)
            {
                for (int j = turns; j < N - turns; j++)
                {
                    array[0 + turns, j] = count;
                    count++;
                }
                for (int i = 1 + turns; i < N - turns; i++)
                {
                    array[i, N - 1 - turns] = count;
                    count++;
                }
                for (int i = N - 2 - turns; i >= 0 + turns; i--)
                {
                    array[N - 1 - turns, i] = count;
                    count++;
                }
                for (int i = N - 2 - turns; i >= 1 + turns; i--)
                {
                    array[i, 0 + turns] = count;
                    count++;
                }
                turns++;
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(array[i, j] == 0) array[i, j] = count;
                }
            }
        }

    }
}
