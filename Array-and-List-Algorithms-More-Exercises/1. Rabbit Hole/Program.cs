using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Rabbit_Hole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> field = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());
            int curentPosicion = 0;
            bool counter = true;
            bool bombed = false;
            do
            {
                bombed = false;
                if (field[curentPosicion] == "RabbitHole")
                {
                    counter = false;
                    Console.Write("You have 5 years to save Kennedy!");
                    break;
                }
                else
                {
                    string[] arr = field[curentPosicion].Split('|');
                    switch (arr[0])
                    {
                        case "Left":
                            energy -= int.Parse(arr[1]);
                            curentPosicion = (Math.Abs(curentPosicion - int.Parse(arr[1]))) % field.Count;
                            break;
                        case "Right":
                            energy -= int.Parse(arr[1]);
                            curentPosicion = Math.Abs(curentPosicion + int.Parse(arr[1])) % field.Count;
                            break;
                        case "Bomb":
                            energy -= int.Parse(arr[1]);
                            field.RemoveAt(curentPosicion);
                            curentPosicion = 0;
                            bombed = true;
                            break;
                        default:
                            break;
                    }
                }
                if (field[field.Count - 1] != "RabbitHole")
                {
                    field.RemoveAt(field.Count - 1);
                }
                field.Add(("Bomb|" + energy));
            }
            while (energy > 0);
            if (bombed)
            {
                counter = false;
                Console.Write("You are dead due to bomb explosion!");
            }
            if (counter)
            {
                Console.Write("You are tired. You can't continue the mission.");
            }
            Console.WriteLine();
        }
    }
}
