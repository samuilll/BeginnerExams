using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Pokemon
{

    public string EvolutionType { get; set; }

    public int EvolutionIndex { get; set; }

    public Pokemon(string type, int index)
    {

        this.EvolutionType = type;

        this.EvolutionIndex = index;
    }
}

class Rask04PokemonEvolution
    {
        static void Main(string[] args)
        {

        var input = Console.ReadLine()
            .Split(new char[] {' ','-','>'},StringSplitOptions.RemoveEmptyEntries);

        var evolutionData = new Dictionary<string, List<Pokemon>>();

        while (input[0]!= "wubbalubbadubdub")
        {
            if (input.Length == 1)
            {
                string currentName = input[0];

                if (evolutionData.ContainsKey(currentName))
                {
                    Console.WriteLine($"# {currentName}");
                    foreach (var evolutionPair in evolutionData[currentName])
                    {
                        Console.WriteLine($"{evolutionPair.EvolutionType} <-> {evolutionPair.EvolutionIndex}");
                    }
                }
            }
            else
            {
                string currentName = input[0];

                string currentEvolutionType = input[1];

                int currentEvolutionIndex = int.Parse(input[2]);

                Pokemon currentPokemon = new Pokemon(currentEvolutionType,currentEvolutionIndex);

                if (!evolutionData.ContainsKey(currentName))
                {
                    evolutionData[currentName] = new List<Pokemon>();
                }

                evolutionData[currentName].Add(currentPokemon);

            }
                            

            input = Console.ReadLine()
            .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
        }

        foreach (var pokemonPair in evolutionData)
        {
            Console.WriteLine($"# {pokemonPair.Key}");

            foreach (var evolutionPair in pokemonPair.Value.OrderByDescending(n=>n.EvolutionIndex))
            {
                Console.WriteLine($"{evolutionPair.EvolutionType} <-> {evolutionPair.EvolutionIndex}");
            }
        }
        }
    }

