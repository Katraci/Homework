using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Most_Valued_Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> shopList = new Dictionary<string, decimal>();
            string input = Console.ReadLine();
            while (input != "Shop is open")
            {
                string[] store = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                shopList[store[0]] = decimal.Parse(store[1]);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> buyerList = new Dictionary<string, Dictionary<string, int>>();
            while (input != "Print")
            {
                if (input == "Discount")
                {
                    List<KeyValuePair<string, decimal>> discount = shopList.OrderByDescending(n => n.Value).Take(3).ToList();
                    for (int i = 0; i < discount.Count; i++)
                    {
                        string product = discount[i].Key;
                        decimal newPrice = (discount[i].Value - discount[i].Value * (decimal)0.1);
                        shopList[product] = newPrice;
                    }
                }
                else
                {
                    string[] curentInput = input.Split(new char[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    if (!buyerList.ContainsKey(curentInput[0]))
                    {
                        buyerList[curentInput[0]] = new Dictionary<string, int>();
                    }
                    for (int i = 1; i < curentInput.Length; i++)
                    {
                        if (!buyerList[curentInput[0]].ContainsKey(curentInput[i]))
                        {
                            buyerList[curentInput[0]][curentInput[i]] = 0;
                        }
                        buyerList[curentInput[0]][curentInput[i]] ++;
                    }
                }
                input = Console.ReadLine();
            }
            string nameMax="";
            decimal spendedMax = 0;
            foreach (var item in buyerList)
            {
                decimal curentSum = 0;
                foreach (var kvp in item.Value)
                {
                    curentSum += (kvp.Value * shopList[kvp.Key]);
                }
                if (curentSum>spendedMax)
                {
                    spendedMax = curentSum;
                    nameMax = item.Key;
                }
            }
            Console.WriteLine($"Biggest spender: {nameMax}");
            Console.WriteLine("^Products bought:");
            var ordered = shopList.OrderByDescending(n => n.Value);
            foreach (var item in ordered)
            {
                if (buyerList[nameMax].ContainsKey(item.Key))
                {
                    Console.WriteLine($"^^^{item.Key}: {shopList[item.Key]:F2}");
                }
                
            }
            Console.WriteLine($"Total: {spendedMax:F2}");
        }
    }
}
