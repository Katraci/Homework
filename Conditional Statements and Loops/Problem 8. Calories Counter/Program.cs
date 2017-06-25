using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());
            int currentIngredient = 1;
            int calories = 0;
            do
            {
                string ingredient = Console.ReadLine().ToLower();
                currentIngredient++;
                switch (ingredient)
                {
                    case "cheese":calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;
                    default:
                        break;
                }
            } while (currentIngredient<=numberOfIngredients);
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
