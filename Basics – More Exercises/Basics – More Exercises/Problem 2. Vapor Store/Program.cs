using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string game = "";
            decimal totalSpent = 0.0M;
            while (game != "game time" || money != 0M)
            {
                game = Console.ReadLine().ToLower();
                switch (game)
                {
                    case "outfall 4":
                        if (money >= 39.99M)
                        {
                            Console.WriteLine("Bought OutFall 4");
                            money -= 39.99M;
                            totalSpent += 39.99M;
                        }
                        else { Console.WriteLine("Too Expensive"); }
                        break;
                    case "cs: og":
                        if (money >= 15.99M)
                        {
                            Console.WriteLine("Bought CS: OG");
                            money -= 15.99M;
                            totalSpent += 15.99M;
                        }
                        else { Console.WriteLine("Too Expensive"); }
                        break;
                    case "zplinter zell":
                        if (money >= 19.99M)
                        {
                            Console.WriteLine("Bought Zplinter Zell");
                            money -= 19.99M;
                            totalSpent += 19.99M;
                        }
                        else { Console.WriteLine("Too Expensive"); }
                        break;
                    case "honored 2":
                        if (money >= 59.99M)
                        {
                            Console.WriteLine("Bought Honored 2");
                            money -= 59.99M;
                            totalSpent += 59.99M;
                        }
                        else { Console.WriteLine("Too Expensive"); }
                        break;
                    case "roverwatch":
                        if (money >= 29.99M)
                        {
                            Console.WriteLine("Bought RoverWatch");
                            money -= 29.99M;
                            totalSpent += 29.99M;
                        }
                        else { Console.WriteLine("Too Expensive"); }
                        break;
                    case "roverwatch origins edition":
                        if (money >= 39.99M)
                        {
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                            money -= 39.99M;
                            totalSpent += 39.99M;
                        }
                        else { Console.WriteLine("Too Expensive"); }
                        break;
                    case "game time":

                        
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (game== "game time")
                {
                    break;
                }
               
            }
            if (money == 0M)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${money:F2}");
            }

        }   
    }
}
