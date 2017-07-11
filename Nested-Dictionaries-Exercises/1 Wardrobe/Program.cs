using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothes = new Dictionary<string, Dictionary<string, int>>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] curentInput = Console.ReadLine().Split(new string[] { " -> " } , StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!clothes.ContainsKey(curentInput[0]))
                {
                    clothes[curentInput[0]]=new Dictionary<string, int>();
                }
                string[] clothesInput = curentInput[1].Split(',').ToArray();
                foreach (string curenInput in clothesInput)
                {

                    if (!clothes[curentInput[0]].ContainsKey(curenInput))
                    {
                        clothes[curentInput[0]][curenInput] = 0;
                    }
                    clothes[curentInput[0]][curenInput] ++;
                }
            }
            string[] input = Console.ReadLine().Split(new char[] { ' ' } , StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in clothes)
            {
                bool checkColor = false;
                if (item.Key==input[0])
                {
                    checkColor = true;
                }
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var clothe in item.Value)
                {
                    if (checkColor&&clothe.Key==input[1])
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value}");
                    }
                }
            }
        }
    }
}
