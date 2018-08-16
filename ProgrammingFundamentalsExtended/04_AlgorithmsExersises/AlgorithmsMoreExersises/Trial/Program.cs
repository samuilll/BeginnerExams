using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitHole01
{
    class RabbitHole01
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var energy = int.Parse(Console.ReadLine());

            var currentIndex = 0;

            var check = false;

            var check2 = false;

            do
            {
                string[] currentCommand = commands[currentIndex].Split('|');

                switch (currentCommand[0])
                {
                    case "Right":
                        {
                            energy = ImplementTheRightCommand(commands, currentCommand, energy, currentIndex);

                            break;
                        }
                    case "Left":
                        {
                            energy = ImplementTheLeftCommand(commands, currentCommand, energy, currentIndex);

                            break;

                        }
                    case "Bomb":
                        {
                            energy = ImplementTheBombCommand(commands, currentCommand, energy, currentIndex);
                            if (energy <= 0)
                            {
                                check2 = true;

                            }
                            break;
                        }
                    case "RabbitHole":
                        {
                            check = true;
                            break;
                        }
                }

                if (energy > 0)
                {
                    AddTheBomb(commands, currentCommand, energy, currentIndex);
                }
            } while (energy > 0 && !check);

            if (check)
            {
                Console.WriteLine("You have 5 years to save Kennedy!");
            }
            else if (!check2)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
            }
            else
            {
                Console.WriteLine("You are dead due to bomb explosion!");
            }

        }

        private static void AddTheBomb(List<string> commands, string[] currentCommand, int energy, int currentIndex)
        {
            if (commands[commands.Count - 1] != "RabbitHole")
            {
                commands.RemoveAt(commands.Count - 1);
                commands.Add($"Bomb|{energy}");
            }
            else
            {
                commands.Add($"Bomb|{energy}");
            }
        }

        private static int ImplementTheBombCommand(List<string> commands, string[] currentCommand, int energy, int currentIndex)
        {
            var moveNumber = int.Parse(currentCommand[1]);

            energy -= moveNumber;

            commands.RemoveAt(currentIndex);

            currentIndex = 0;

            return energy;

        }

        private static int ImplementTheRightCommand(List<string> commands, string[] currentCommand, int energy, int currentIndex)
        {
            var moveNumber = int.Parse(currentCommand[1]);

            currentIndex = currentIndex += moveNumber;

            if (currentIndex >= commands.Count)
            {
                currentIndex = currentIndex % commands.Count;
            }

            energy -= moveNumber;

            return energy;

        }

        private static int ImplementTheLeftCommand(List<string> commands, string[] currentCommand, int energy, int currentIndex)
        {
            var moveNumber = int.Parse(currentCommand[1]);

            currentIndex = Math.Abs(currentIndex -= moveNumber);

            if (currentIndex <= commands.Count)
            {
                currentIndex = commands.Count % currentIndex;
            }
            else
            {
                currentIndex = currentIndex % commands.Count;
            }

            energy -= moveNumber;

            return energy;

        }
    }
}
