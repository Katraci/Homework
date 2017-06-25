using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int purchase = int.Parse(Console.ReadLine());
            int counter = 0;
            decimal spendMoney = 0.0M;
            if (purchase != 0)
            {
                while (true)
                {
                    counter++;
                    string product = Console.ReadLine();
                    decimal price = decimal.Parse(Console.ReadLine());
                    decimal quantify = decimal.Parse(Console.ReadLine());
                    if (quantify > 1.0M)
                    {
                        Console.WriteLine($"Adding {quantify} {product}s to cart.");
                    }
                    else
                    {
                        Console.WriteLine($"Adding {quantify} {product} to cart.");
                    }
                    spendMoney += quantify * price;
                    if (counter == purchase) break;
                }
            }
            Console.WriteLine($"Subtotal: ${spendMoney:F2}");
            if (budget>=spendMoney)
            {
                Console.WriteLine($"Money left: ${budget - spendMoney:F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${spendMoney - budget} more.");
            }
        }
    }
}
