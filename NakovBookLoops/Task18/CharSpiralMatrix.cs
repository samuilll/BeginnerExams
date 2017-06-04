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
            char[,] array = new char[N, N];
            string name = Console.ReadLine();
            int count = 1;
            FullTheMatrixWithElement(array, '*');


            SpiraMatrix(array, N,name);
            Console.WriteLine();
            Console.WriteLine();

            
            ShowTheMatrix(array);
            

        }
        static void ShowTheMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]+" ");
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
        static void SpiraMatrix(char[,] array,int N, string name)
        {
            var count = 0;
           
            var turns = 0;
            while (turns < N / 2)
            {
                for (int j = turns; j < N - turns; j++)
                {
                    array[0 + turns, j] = name[count];
                    count++;
                    if (count == name.Length) count = 0;
                }
                for (int i = 1 + turns; i < N - turns; i++)
                {
                    array[i, N - 1 - turns] = name[count];
                    count++;
                    if (count == name.Length) count = 0;
                }
                for (int i = N - 2 - turns; i >= 0 + turns; i--)
                {
                    array[N - 1 - turns, i] = name[count];
                    count++;
                    if (count == name.Length) count = 0;
                }
                for (int i = N - 2 - turns; i >= 1 + turns; i--)
                {
                    array[i, 0 + turns] = name[count];
                    count++;
                    if (count == name.Length) count = 0;
                }
                turns++;
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(array[i, j] == 0) array[i, j] = name[count];
                }
            }
        }

    }
}
