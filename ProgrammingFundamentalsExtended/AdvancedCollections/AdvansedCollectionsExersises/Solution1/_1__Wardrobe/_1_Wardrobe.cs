using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__Wardrobe
{
    class _1_Wardrobe
    {
        static void Main(string[] args)
        {
            var howManyTimes = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();


            

            for (int i = 0; i < howManyTimes; i++)
            {
                var input = Console.ReadLine().Split(new string[] {" -> " }, StringSplitOptions.RemoveEmptyEntries);

                var colour = input[0];

                var clothes = input[1].Split(',');

                AddTheClothesInWardrobe(wardrobe, colour, clothes);

            }

            var wanted = Console.ReadLine().Split();

            var wantedColour = wanted[0];

            var wantedClothe = wanted[1];

            PrintTheWardrobe(wardrobe,wantedColour,wantedClothe);
        }

        private static void PrintTheWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe,string wantedColour,string wantedClothe)
        {
            foreach (var colour in wardrobe.Keys)
            {
                Console.WriteLine($"{colour} clothes:");

                foreach (var clothe in wardrobe[colour].Keys)
                {
                    if (colour == wantedColour && clothe == wantedClothe)
                    {
                        Console.WriteLine($"* {clothe} - {wardrobe[colour][clothe]} (found!)");

                    }
                    else
                    {
                        Console.WriteLine($"* {clothe} - {wardrobe[colour][clothe]}");
                    }
                }
            }
        }

        private static void AddTheClothesInWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe, string colour, string[] clothes)
        {
            if (!wardrobe.ContainsKey(colour))
            {
                wardrobe[colour] = new Dictionary<string, int>();
            }
            for (int i = 0; i < clothes.Length; i++)
            {
                if (!wardrobe[colour].ContainsKey(clothes[i]))
                {
                    wardrobe[colour][clothes[i]] = 1;

                }
                else
                {

                    wardrobe[colour][clothes[i]] += 1;
                }

            }
        }
    }
}
