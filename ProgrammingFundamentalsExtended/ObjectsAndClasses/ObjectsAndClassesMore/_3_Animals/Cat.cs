using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int IntelligenceQuotient { get; set; }

        public static string ProduceSound()
        {
            return "I’m an Aristocat, and I will now produce an aristocratic sound! Myau Myau.";
        }

        public static Cat Parse(string inputLine)
        {
            var currentCat = new Cat();

            var separateInput = inputLine
             .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .ToList();

            currentCat.Name = separateInput[1];

            currentCat.Age = int.Parse(separateInput[2]);

            currentCat.IntelligenceQuotient = int.Parse(separateInput[3]);

            return currentCat;
        }
    }

