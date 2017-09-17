using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalElections03
{
    class LocalElections03
    {
        static void Main(string[] args)
        {
            var numberOfCandidates = int.Parse(Console.ReadLine());
            var voteNumber = int.Parse(Console.ReadLine());
            var symbol = char.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfCandidates; i++)
            {
                if (i == voteNumber) ChosenBallot(symbol, i);
                else OtherBallots(i);
            }
            Console.WriteLine(".............");
        }

        private static void OtherBallots(int n)
        {
            Console.WriteLine(".............");
            Console.WriteLine("...+-----+...");
            Console.WriteLine("...|.....|...");
            Console.WriteLine("{0}.|.....|...",n.ToString("D2"));
            Console.WriteLine("...|.....|...");
            Console.WriteLine("...+-----+...");
        }

        private static void ChosenBallot(char symbol,int n)
        {
            if (symbol == 'x' || symbol == 'X')
            {
                Console.WriteLine(".............");
                Console.WriteLine("...+-----+...");
                Console.WriteLine("...|.\\./.|...");
                Console.WriteLine("{0}.|..{1}..|...", n.ToString("D2"), Char.ToUpper(symbol));
                Console.WriteLine("...|./.\\.|...");
                Console.WriteLine("...+-----+...");
            }
            else
            {
                Console.WriteLine(".............");
                Console.WriteLine("...+-----+...");
                Console.WriteLine("...|\\.../|...");
                Console.WriteLine("{0}.|.\\./.|...", n.ToString("D2"));
                Console.WriteLine("...|..{0}..|...",Char.ToUpper(symbol));
                Console.WriteLine("...+-----+...");
            }
        }
    }
}
