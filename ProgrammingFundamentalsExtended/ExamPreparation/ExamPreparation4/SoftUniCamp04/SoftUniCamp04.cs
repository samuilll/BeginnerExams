using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp04
{
    class SoftUniCamp04
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());

            var allSudents = 0;
            var carStudents = 0;
            var vanStudents = 0;
            var smallBusSudents = 0;
            var bigBusSudents = 0;
            var trainStudents = 0;

            for (int i = 0; i < groupsCount; i++)
            {
               int peopleInGroup = int.Parse( Console.ReadLine());

                allSudents = allSudents + peopleInGroup;
                if (peopleInGroup <= 5)

                    carStudents = carStudents + peopleInGroup;

                else if (peopleInGroup <= 12)

                    vanStudents = vanStudents + peopleInGroup;

                else if (peopleInGroup <= 25)

                    smallBusSudents = smallBusSudents + peopleInGroup;

                else if (peopleInGroup <= 40)

                    bigBusSudents = bigBusSudents + peopleInGroup;

                else

                    trainStudents = trainStudents + peopleInGroup;

            }
            Console.WriteLine("{0:f2}%",carStudents*100.0/allSudents);
            Console.WriteLine("{0:f2}%", vanStudents * 100.0 / allSudents);
            Console.WriteLine("{0:f2}%", smallBusSudents * 100.0 / allSudents);
            Console.WriteLine("{0:f2}%", bigBusSudents * 100.0 / allSudents);
            Console.WriteLine("{0:f2}%", trainStudents * 100.0 / allSudents);
        }
    }
}
