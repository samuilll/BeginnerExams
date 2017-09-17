using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Dog
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int NumberOfLegs { get; set; }

        public static string ProduceSound()
        {
            return "I’m a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.";
        }

        public static Dog Parse(string inputLine)
        {
            var currentDog = new Dog();

            var separateInput = inputLine
             .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .ToList();

            currentDog.Name = separateInput[1];

            currentDog.Age = int.Parse(separateInput[2]);

            currentDog.NumberOfLegs = int.Parse(separateInput[3]);

            return currentDog;
        }
    }

