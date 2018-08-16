using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
class _3_Animals
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var Dogs = new List<Dog>();

            var Cats = new List<Cat>();

            var Snakes = new List<Snake>();

            var whatToDo = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First();

            while (whatToDo != "I'm")
            {
                if (whatToDo == "Dog")
                {
                    var currentDog = Dog.Parse(inputLine);

                    Dogs.Add(currentDog);
                }
                else if (whatToDo == "Cat")
                {
                    var currentCat = Cat.Parse(inputLine);

                    Cats.Add(currentCat);
                }
                else if (whatToDo == "Snake")
                {
                    var currentSnake = Snake.Parse(inputLine);

                    Snakes.Add(currentSnake);
                }
                else
                {
                    var name = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Last();

                    ProduceSounds(name, Dogs, Cats, Snakes);
                }

                inputLine = Console.ReadLine();

                whatToDo = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First();
            }

            PrintTheDogsList(Dogs);
            PrintTheCatsList(Cats);
            PrintTheSnakesList(Snakes);
        }

        private static void PrintTheSnakesList(List<Snake> snakes)
        {
            foreach (var snake in snakes)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }

        private static void PrintTheCatsList(List<Cat> cats)
        {
            foreach (var cat in cats)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }
        }

        private static void PrintTheDogsList(List<Dog> dogs)
        {
            foreach (var dog in dogs)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }
        }

        private static void ProduceSounds(string name, List<Dog> dogs, List<Cat> cats, List<Snake> snakes)
        {
            if (dogs.Any(dog => dog.Name == name))
            {
                Console.WriteLine($"{Dog.ProduceSound()}");
            }
            else if (cats.Any(cat => cat.Name == name))
            {
                Console.WriteLine($"{Cat.ProduceSound()}");

            }
            else
            {
                Console.WriteLine($"{Snake.ProduceSound()}");

            }
        }
    }

