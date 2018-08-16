using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_NilapDromes
{
    class _8_NilapDromes
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            while (word != "end")
            {
                var palyndrom = string.Empty;

                palyndrom = IsTheWordPalyndrom(word);

                if (palyndrom != string.Empty)
                {
                    Console.WriteLine(palyndrom);
                }

                word = Console.ReadLine();
            }
        }

        private static string IsTheWordPalyndrom(string word)
        {
            var core = new StringBuilder();

            var endCore = string.Empty;

            var checkTheCores = false;

            core = GenerateTheFirstSuspisiousCore(word, core);

            endCore = GenerateASuspisiousEndCore(word, core);

            checkTheCores = IsTheStartAndEndCoresEquals(core, endCore);

            while (!checkTheCores)
            {
                core = GenerateASuspisiousCoreAgain(endCore, core);

                endCore = GenerateASuspisiousEndCore(word, core);

                checkTheCores = IsTheStartAndEndCoresEquals(core, endCore);
            }

            var isTheCoreInvalid = (core.Length * 2 >= word.Length);

            var coreIsEmty = endCore == string.Empty;

            if (AllLettersIsTheSame(word))
            {
                return word;
            }
            else if (isTheCoreInvalid || coreIsEmty)
            {
                return string.Empty;

            }

            else
            {
                var coreAsString = core.ToString();

                var border = word.Remove(0, coreAsString.Length);

                border = border.Remove(border.Length - coreAsString.Length, coreAsString.Length);

                return border + core + border;
            }



        }

        private static bool AllLettersIsTheSame(string word)
        {

            var check = true;

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 1; j < word.Length; j++)
                {
                    if (word[i] != word[j])
                    {
                        check = false;
                        break;
                    }
                    if (!check)
                    {
                        break;
                    }
                }
            }

            return check;
        }

        private static StringBuilder GenerateASuspisiousCoreAgain(string endCore, StringBuilder core)
        {

            var newCore = new StringBuilder();

            for (int coreIndex = 0; coreIndex < core.Length; coreIndex++)
            {
                var letter = core[coreIndex];

                newCore.Append(letter);

                var currentWord = newCore.ToString();

                if (endCore.IndexOf(currentWord) == -1)
                {
                    newCore.Remove(newCore.Length - 1, 1);
                    break;
                }

            }

            return newCore;
        }

        private static string GenerateASuspisiousEndCore(string word, StringBuilder core)
        {
            var stringCore = core.ToString();

            var endCore = string.Empty;

            var endCoreStartIndex = (word.Length - 1) - (stringCore.Length - 1);

            for (int i = endCoreStartIndex; i < word.Length; i++)
            {
                endCore += word[i];
            }

            return endCore;
        }

        private static bool IsTheStartAndEndCoresEquals(StringBuilder core, string endCore)
        {
            var stringCore = core.ToString();

            if (stringCore.Equals(endCore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static StringBuilder GenerateTheFirstSuspisiousCore(string word, StringBuilder core)
        {

            var halfLengthIndex = (int)(Math.Ceiling((double)word.Length /2));

            for (int index = 0; index < word.Length; index++)
            {
                var Letter = word[index];

                core.Append(Letter);

                var currentWord = core.ToString();

                if (word.IndexOf(currentWord, halfLengthIndex) == -1)
                {
                    core.Remove(core.Length - 1, 1);

                    break;
                }
            }

            return core;
        }

    }
}
