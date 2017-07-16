using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapanesseRoulette02
{
    class JapannesseRoulette
    {
        static void Main(string[] args)
        {
            int[] revolver = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var players = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            bool isAlive = true;

            for (int i = 0; i < players.Length; i++)
            {
                 isAlive = OneTrying(players[i], revolver);

                if (!isAlive)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");

                    break;
                }
            }

            if (isAlive)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }

        private static bool OneTrying(string player, int[] revolver)
        {
            var directionAndStrength = player.Split(',');

            bool isAlive = false;

            var stregth = int.Parse(directionAndStrength[0]);

            var direction = directionAndStrength[1];

            if (direction == "Right")
            {
                 isAlive = CaseRightDirection(revolver, stregth, direction);
            }
            else
            {
                isAlive = CaseLeftDirection(revolver, stregth, direction);
            }

            return isAlive;

        }

        private static bool CaseLeftDirection(int[] revolver, int stregth, string direction)
        {
            var bulletIndex = WhereIsTheBullet(revolver);

            revolver[bulletIndex] = 0;

            while (stregth>0)
            {
                bulletIndex--;

                stregth--;

                if (bulletIndex<0)
                {
                    bulletIndex = revolver.Length - 1;
                }
            }

            revolver[bulletIndex] = 1;

            var isAlive = PushTheTrigger(revolver, bulletIndex);

            return isAlive;
        }

        private static bool CaseRightDirection(int[] revolver, int stregth, string direction)
        {
            var bulletIndex = WhereIsTheBullet(revolver);

            revolver[bulletIndex] = 0;

            while (stregth > 0)
            {
                bulletIndex++;

                stregth--;

                if (bulletIndex >revolver.Length-1)
                {
                    bulletIndex = 0;
                }
            }

            revolver[bulletIndex] = 1;

            var isAlive = PushTheTrigger(revolver,bulletIndex);

            return isAlive;
        }

        private static bool PushTheTrigger(int[] revolver,int newBulletIndex)
        {
            var isAlive = true;

            if (revolver[2] == 1)
            {
                isAlive = false;
            }
            else
            {
                isAlive = true;
            }

            revolver[newBulletIndex] = 0;

            if (newBulletIndex==revolver.Length-1)
            {
                revolver[0] = 1;
            }
            else
            {
                revolver[newBulletIndex + 1] = 1;
            }

            return isAlive;
        }

        private static int WhereIsTheBullet(int[] revolver)
        {
            var index = 0;
            for (int i = 0; i < revolver.Length; i++)
            {
                if (revolver[i] == 1)
                {
                    index = i;
                }
            }
            return index;
        }
    }
}
