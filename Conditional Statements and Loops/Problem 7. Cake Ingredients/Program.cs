using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string ingredient = "none";
            while (counter<=20)
            {
                ingredient = Console.ReadLine();
                if (ingredient== "Bake!")
                {
                    break;
                }
                Console.WriteLine($"Adding ingredient {ingredient}.");
                counter++;
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
                
           
        }
    }
}
