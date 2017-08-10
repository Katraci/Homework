using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Grocery_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,decimal> groceryList = new Dictionary<string, decimal>();
            string filter = @"(^[A-Z])([a-z]+)([:])(\d+)([.])(\d{2})$";
            string input = Console.ReadLine();
            while (input!="bill")
            {
                if (Regex.IsMatch(input,filter))
                {
                    string[] grocery = input.Split(':');
                    string product = grocery[0];
                    decimal price = decimal.Parse(grocery[1]);
                    groceryList[product] = price;
                }
                input = Console.ReadLine();
            }
            var sorted = groceryList.OrderByDescending(n => n.Value);
            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Key} costs {item.Value}");
            }
        }
    }
}
