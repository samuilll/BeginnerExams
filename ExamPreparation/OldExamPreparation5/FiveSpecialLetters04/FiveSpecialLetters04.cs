using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveSpecialLetters04
{
    class FiveSpecialLetters04
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            var check = false;

            for (char letter1 = 'a'; letter1 < 'f'; letter1++)
            {
                for (char letter2 = 'a'; letter2 < 'f'; letter2++)
                {
                    for (char letter3 = 'a'; letter3 < 'f'; letter3++)
                    {
                        for (char letter4 = 'a'; letter4 < 'f'; letter4++)
                        {
                            for (char letter5 = 'a'; letter5 < 'f'; letter5++)
                            {
                                string text = FindTheRightLetters(letter1, letter2, letter3, letter4, letter5);
                                int sum = FindTheSum(text);
                                if (sum >= start && sum <= end)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", letter1, letter2, letter3, letter4, letter5);
                                        check = true;
                                }
                            }
                        }
                    }
                }
            }
            if (!check)
                Console.Write("No");
            Console.WriteLine();
        }

        private static int FindTheSum(string text)
        {
            int[] numbers = new int[] { 5, -12, 47, 7, -32 };
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e' };
            var sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a': sum = sum + numbers[0] * (i + 1); break;
                    case 'b': sum = sum + numbers[1] * (i + 1); break;
                    case 'c': sum = sum + numbers[2] * (i + 1); break;
                    case 'd': sum = sum + numbers[3] * (i + 1); break;
                    case 'e': sum = sum + numbers[4] * (i + 1); break;

                }
            }
            return sum;
        }

        private static string FindTheRightLetters(char letter1, char letter2, char letter3, char letter4, char letter5)
        {
            string text = letter1.ToString() + letter2.ToString() + letter3.ToString() + letter4.ToString() + letter5.ToString();
            string newtext = "";
            var count = 0;
            var check = new bool[] { true, true, true, true, true };

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        count++;
                    }
                    if (count > 1)

                        check[j] = false;

                }
                for (int p = 0; p < check.Length; p++)
                {
                    if (check[p] && CheckTheNewtext(newtext, text[p])) newtext += text[p];
                }

                count = 0;
                CleanTheBoolArray(check);
            }
            return newtext;
        }

        private static void CleanTheBoolArray(bool[] check)
        {
            for (int i = 0; i < check.Length; i++)
            {
                check[i] = true;
            }
        }
        private static bool CheckTheNewtext(string newtext, char letter)
        {
            var check = true;
            for (int i = 0; i < newtext.Length; i++)
            {
                if (newtext[i] == letter)
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
    }
}
