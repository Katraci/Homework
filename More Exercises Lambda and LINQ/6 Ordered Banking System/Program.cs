using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Ordered_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> bankList = new Dictionary<string, Dictionary<string, decimal>>();
            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] curentInput = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string bank = curentInput[0];
                string name = curentInput[1];
                decimal money = decimal.Parse(curentInput[2]);
                if (!bankList.ContainsKey(bank))
                {
                    bankList[bank] = new Dictionary<string, decimal>();
                }
                if (!bankList[bank].ContainsKey(name))
                {
                    bankList[bank][name] = 0;
                }
                bankList[bank][name] += money;
                input = Console.ReadLine();
            }
            var sorted = bankList.OrderByDescending(n => n.Value.Values.Sum()).ThenByDescending(n => n.Value.Values.Max());
            foreach (var item in sorted)
            {
                string bank = item.Key;
                var moneyOwners = item.Value.OrderByDescending(kvp => kvp.Value);
                foreach (var kvp in moneyOwners)
                {
                    decimal money = kvp.Value;
                    string name = kvp.Key;
                    Console.WriteLine($"{name} -> {money} ({bank})");
                }
            }
        }
    }
}
