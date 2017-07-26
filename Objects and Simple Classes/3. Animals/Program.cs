using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> dogs = new List<Animal>();
            List<Animal> cats = new List<Animal>();
            List<Animal> snakes = new List<Animal>();
            string input = Console.ReadLine();
            while (input!= "I'm your Huckleberry")
            {
                string[] curentInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string token = curentInput[0];
                switch (token)
                {
                    case "talk":
                        if (IsAnimalHere(curentInput[1],dogs))
                        {
                            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
                        }
                        else
                        {
                            if (IsAnimalHere(curentInput[1], cats))
                            {
                                Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
                            }
                            else
                            {
                                if (IsAnimalHere(curentInput[1], snakes))
                                {
                                    Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
                                }
                            }
                        }
                        break;
                    case "Dog": dogs.Add(AnimalToEnter(curentInput));break;
                    case "Cat": cats.Add(AnimalToEnter(curentInput)); break;
                    case "Snake": snakes.Add(AnimalToEnter(curentInput)); break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
            foreach (var item in dogs)
            {
                Console.WriteLine($"Dog: {item.Name}, Age: {item.Age}, Number Of Legs: {item.Specification}");
            }
            foreach (var item in cats)
            {
                Console.WriteLine($"Cat: {item.Name}, Age: {item.Age}, IQ: {item.Specification}");
            }
            foreach (var item in snakes)
            {
                Console.WriteLine($"Snake: {item.Name}, Age: {item.Age}, Cruelty: {item.Specification}");
            }
        }



        private static Animal AnimalToEnter(string[] curentInput)
        {
            Animal result = new Animal
            {
                Name = curentInput[1],
                Age=int.Parse(curentInput[2]),
                Specification=int.Parse(curentInput[3])
            };
                return result;
        }

        static bool IsAnimalHere(string name, List<Animal> animals)
        {
            bool result = false;
            List<string> listOfNames = animals.Select(a => a.Name).ToList();
            if (listOfNames.Contains(name))
            {
                result = true;
            }
            return result;
        }

        class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int Specification { get; set; }
        }

    }
}
