using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> shells = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();
            while (input!= "Aggregate")
            {
                string[] curentShell = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string city = curentShell[0];
                int size = int.Parse(curentShell[1]);
                if (!shells.ContainsKey(city))
                {
                    shells[city] = new List<int>();
                }
                if (!shells[city].Contains(size))
                {
                    shells[city].Add(size);
                }
                input = Console.ReadLine();
            }
            foreach (var shell in shells)
            {
                Console.Write($"{shell.Key} -> ");
                Console.Write(string.Join(", ", shell.Value));
                int sum = 0;
                foreach (var item in shell.Value)
                {
                    sum += item;
                }
                Console.WriteLine($" ({sum - (sum / shell.Value.Count)})");

            }
        }
    }
}
