using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task02PokemonDontGo
    {
        static void Main(string[] args)
        {

        var sequence = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var searchedSum = 0;

        while (sequence.Count>0)
        {
            var elementIndexToRemove = int.Parse(Console.ReadLine());

           searchedSum+= ChangeTheSequence(sequence, elementIndexToRemove);
        }

        Console.WriteLine(searchedSum);
        }

    private static int ChangeTheSequence(List<int> sequence, int index)
    {
        int currentElement;
        if (index < 0)
        {
            currentElement = sequence[0];
            sequence.RemoveAt(0);
            sequence.Insert(0, sequence[sequence.Count-1]);
        }

        else if (index >= sequence.Count)
        {
            currentElement = sequence[sequence.Count-1];
            sequence.RemoveAt(sequence.Count-1);
            sequence.Add(sequence[0]);
        }
        else
        {
            currentElement = sequence[index];
            sequence.RemoveAt(index);
        }

        for (int i = 0; i < sequence.Count; i++)
        {
            if (sequence[i]<=currentElement)
            {
                sequence[i] += currentElement;
            }
            else
            {
                sequence[i] -= currentElement;
            }
        }

     //   Console.WriteLine(string.Join(" ",sequence));

        return currentElement;
    }   
}

