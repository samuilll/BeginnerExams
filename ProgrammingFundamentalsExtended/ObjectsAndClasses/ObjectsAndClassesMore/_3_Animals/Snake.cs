using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Snake
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int CrueltyCoefficient { get; set; }

        public static string ProduceSound()
        {
            return "I’m a Sophistisnake, and I will now produce a sophisticated sound! Honey, I’m home.";
        }

        public static Snake Parse(string inputLine)
        {
            var currentSnake = new Snake();

            var separateInput = inputLine
             .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
             .ToList();

            currentSnake.Name = separateInput[1];

            currentSnake.Age = int.Parse(separateInput[2]);

            currentSnake.CrueltyCoefficient = int.Parse(separateInput[3]);

            return currentSnake;
        }
    }

