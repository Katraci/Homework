using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Camping
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> record = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] curentInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = curentInput[0];
                string camp = curentInput[1];
                int days = int.Parse(curentInput[2]);
                if (!record.ContainsKey(name))
                {
                    record[name] = new Dictionary<string, int>();
                }
                record[name][camp] = days;
                input = Console.ReadLine();
            }
            foreach (var item in record.OrderByDescending(n=>n.Value.Count).ThenBy(n=>n.Key.Length))
            {
                string name = item.Key;
                var camp = item.Value;
                int days = camp.Values.Sum();
                Console.WriteLine($"{name}: {camp.Count}");
                foreach (var part in camp)
                {
                    Console.WriteLine($"***{part.Key}");
                }
                Console.WriteLine($"Total stay: {days} nights");
            }
        }
    }
}
