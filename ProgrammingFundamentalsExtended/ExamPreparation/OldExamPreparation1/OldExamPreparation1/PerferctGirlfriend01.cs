using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldExamPreparation1
{
    class PerferctGirlfriend01
    {
        static void Main(string[] args)
        {
            var check = true;
            var success = 0;

            while (check == true)
            {
                string input = Console.ReadLine();
                var result = 0;


                if (input == "Enough dates!") { check = false; Console.WriteLine(success); break; }

                string[] elements = input.Split('\\');

                string day = elements[0];
                string phoneNumber = elements[1];
                string braSize = elements[2];
                string name = elements[3];

                int dayNumber = NumberOfDayNumber(day);

                int phoneSum = PhoneSum(phoneNumber);

                int braNumber = BraSum(braSize);

                int nameNumber = NameSum(name);

                result = dayNumber + phoneSum + braNumber - nameNumber;

                if (result >= 6000)
                {
                    Console.WriteLine($"{name} is perfect for you.");
                    success++;
                }

                else
                    Console.WriteLine($"Keep searching, {name} is not for you.");


            }
        }

        private static int NameSum(string name)
        {
            int number = Convert.ToInt32(name[0]);
            return number * name.Length;
        }

        private static int BraSum(string braSize)
        {
            var letterNumber = Convert.ToInt32(braSize[braSize.Length - 1]);
            braSize = braSize.Substring(0, braSize.Length - 1);
            var number = int.Parse(braSize.ToString());
            var result = letterNumber * number;
            return result;


        }

        private static int PhoneSum(string phoneNumber)
        {
            int sum = 0;
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                sum = sum + int.Parse(phoneNumber[i].ToString());
            }
            return sum;
        }

        private static int NumberOfDayNumber(string day)
        {
            var number = 0;
            switch (day)
            {
                case "Monday": number = 1; break;
                case "Tuesday": number = 2; break;
                case "Wednesday": number = 3; break;
                case "Thursday": number = 4; break;
                case "Friday": number = 5; break;
                case "Saturday": number = 6; break;
                case "Sunday": number = 7; break;

            }
            return number;
        }
    }
}
