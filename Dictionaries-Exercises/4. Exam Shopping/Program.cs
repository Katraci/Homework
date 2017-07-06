using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Exam_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            string input = "";
            while (input!= "shopping time")
            {
                input = Console.ReadLine();
                if (input != "shopping time")
                {
                    string[] arr = input.Split(' ').ToArray();
                    if (!inventory.ContainsKey(arr[1]))
                    {
                        inventory[arr[1]] = int.Parse(arr[2]);
                    }
                    else
                    {
                        inventory[arr[1]] = inventory[arr[1]] + int.Parse(arr[2]);
                    }
                }
            }
            while (input != "exam time")
            {
                input = Console.ReadLine();
                if (input != "exam time")
                {
                    string[] arr = input.Split(' ').ToArray();
                    if (!inventory.ContainsKey(arr[1]))
                    {
                        Console.WriteLine($"{arr[1]} doesn't exist");
                    }
                    else
                    {
                        if (inventory[arr[1]]>0)
                        {
                            inventory[arr[1]]= inventory[arr[1]] - int.Parse(arr[2]);
                        }
                        else
                        {
                            Console.WriteLine($"{arr[1]} out of stock");
                        }
                    }
                }
            }
            foreach (KeyValuePair<string,int> item in inventory)
            {
                if (item.Value>0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
