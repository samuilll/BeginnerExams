using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_DiamondProblem
{
    class _2_DiamondProblem
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var isThereADiamonds = false;

            for (int index = 0; index < text.Length; index++)
            {
                if (text[index] == '<')
                {
                    for (int secondIndex = index; secondIndex < text.Length; secondIndex++)
                    {
                        if (text[secondIndex] == '>')
                        {
                            var diamondLength = secondIndex - index + 1;

                            var diamond = text.Substring(index, diamondLength).Trim('<', '>');

                    //        Console.WriteLine(diamond.Trim('<', '>'));

                            int carats = CalculateTheDiamondValue(diamond);

                            Console.WriteLine($"Found {carats} carat diamond");

                            index = secondIndex - 1;

                            isThereADiamonds = true;

                            break;
                        }
                    }
                }
            }

            if (!isThereADiamonds)
            {
                Console.WriteLine("Better luck next time");
            }
        }

        private static int CalculateTheDiamondValue(string diamond)
        {
            var carats = 0;

            for (int i = 0; i < diamond.Length; i++)
            {
                if (char.IsDigit(diamond[i]))
                {
                    carats += int.Parse(diamond[i].ToString());
                }
            }

            return carats;
        }
    }
}
