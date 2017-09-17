using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldExam
{
    class LongestWord
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var N = int.Parse(Console.ReadLine());
            char[,] block = new char[N, N];
            char[,] HelpBlock = new char[N, N];
            FullTheMatrixWithWord(block, word);
            ShowTheMatrix(block);
            FullTheMatrixWithElement(HelpBlock, '*');
            var count = 1;
            var maxcount = 0;
            var index1 = 0;
            var index2 = 0;
            var maxindex1 = 0;
            var maxindex2 = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N-1; j++)
                {
                    if (block[i, j] < block[i, j + 1])
                    {
                        HelpBlock[i, j] = block[i, j];
                        HelpBlock[i, j + 1] = block[i, j + 1];
                    }
                }

            }
            ShowTheMatrix(HelpBlock);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N-1; j++)
                {
                    if ((HelpBlock[i, j] < HelpBlock[i, j + 1])&& (j!=N-2))
                    {
                        count++;
                        index1 = i;
                        index2 = j + 1;
                    }
                  else  if ((HelpBlock[i, j] < HelpBlock[i, j + 1]) && (j == N - 2))
                    {
                        count++;
                        index1 = i;
                        index2 = j + 1;
                        if (maxcount < count)
                        {
                            maxcount = count;
                            maxindex1 = index1;
                            maxindex2 = index2;
                        }
                    }
                    else
                    {
                        if (maxcount < count)
                        {
                            maxcount = count;
                            maxindex1 = index1;
                            maxindex2 = index2;
                        }
                        count = 0;
                    }
                }
                count = 0;
            }
            for (int i = maxindex2-maxcount+1; i <=maxindex2; i++)
            {
                Console.Write(HelpBlock[maxindex1,i]);

            }
            Console.WriteLine();
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N - 1; i++)
                {
                    if ((HelpBlock[i, j] < HelpBlock[i+1, j]) && (i != N - 2))
                    {
                        count++;
                        index1 = i+1;
                        index2 = j;
                    }
                    else if ((HelpBlock[i, j] < HelpBlock[i+1, j]) && (i == N - 2))
                    {
                        count++;
                        index1 = i+1;
                        index2 = j;
                        if (maxcount < count)
                        {
                            maxcount = count;
                            maxindex1 = index1;
                            maxindex2 = index2;
                        }
                    }
                    else
                    {
                        if (maxcount < count)
                        {
                            maxcount = count;
                            maxindex1 = index1;
                            maxindex2 = index2;
                        }
                        count = 1;
                    }
                }
                count = 1;
            }
            for (int i = maxindex1 - maxcount + 1; i <= maxindex1; i++)
            {
                Console.Write(HelpBlock[i, maxindex2]);

            }
        }
        
        static void FullTheMatrixWithWord(char[,] matrix,string Word)
        {
            var CountLetters = 0;
            for (int i = 0; i <matrix.GetLength(0) ; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Word[CountLetters];
                    CountLetters++;
                    if (CountLetters == Word.Length)
                        CountLetters = 0;

                }

            }
        }
        static void ShowTheMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
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

    }
}
