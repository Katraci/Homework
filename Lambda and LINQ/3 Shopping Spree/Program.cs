using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal buget = decimal.Parse(Console.ReadLine());
            Dictionary<string, decimal> shopingList = new Dictionary<string, decimal>();
            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] arr = input.Split(new char[]{ ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!shopingList.ContainsKey(arr[0]))
                {
                    shopingList[arr[0]] = decimal.Parse(arr[1]);
                }
                else
                {
                    if (shopingList[arr[0]]> decimal.Parse(arr[1]))
                    {
                        shopingList[arr[0]] = decimal.Parse(arr[1]);
                    }
                }
                input = Console.ReadLine();
            }
            decimal price = shopingList.Sum(k=>k.Value);
            if (price>buget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                var sorted = shopingList.OrderByDescending(k => k.Value).ThenBy(k=>k.Key.Length);
                foreach (var item in sorted)
                {
                    Console.WriteLine($"{item.Key} costs {item.Value:F2}");
                }
            }
        }
    }
}
