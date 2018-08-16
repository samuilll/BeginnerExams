using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _2_Icarus
{
    static void Main(string[] args)
    {

        var sequence = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        var position = int.Parse(Console.ReadLine());

        var damage = 1;

        var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        var damagePostion = new List<int>();

        while (line[0] != "Supernova")
        {
            if (line[0] == "left")
            {
                var move = int.Parse(line[1]);

                damagePostion = LeftFunctionPosition(sequence, position, damage, move, damagePostion);

                position = damagePostion[0];

                damage = damagePostion[1];
            }
            else if (line[0] == "right")
            {
                var move = int.Parse(line[1]);

                damagePostion = RightFunctionPosition(sequence, position, damage, move, damagePostion);

                position = damagePostion[0];

                damage = damagePostion[1];

            }

            line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        Console.WriteLine(string.Join(" ", sequence));
    }

    private static List<int> RightFunctionPosition(List<int> sequence, int position, int damage, int move, List<int> damagePosition)
    {
        damagePosition.Clear();

        while (move > 0)
        {
            if (position!=sequence.Count-1)
            {
                position++;
            }
            else
            {
                position = 0;

                damage += 1;
            }

            sequence[position] -= damage;

            move--;
        }

        damagePosition.Add(position);

        damagePosition.Add(damage);

        return damagePosition;
    }

    private static List<int> LeftFunctionPosition(List<int> sequence, int position, int damage, int move, List<int> damagePosition)
    {
        damagePosition.Clear();

        while (move > 0)
        {
            if (position != 0)
            {
                position--;
            }
            else
            {
                position = sequence.Count - 1;

                damage += 1;
            }

            sequence[position] -= damage;

            move--;   
        }

        damagePosition.Add(position);

        damagePosition.Add(damage);

        return damagePosition;
    }
}

