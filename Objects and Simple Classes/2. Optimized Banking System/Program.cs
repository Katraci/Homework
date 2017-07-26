using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Optimized_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> bankList = new List<BankAccount>();
            string input = Console.ReadLine();
            while (input!="end")
            {
                bankList.Add(EnterNewAccount(input));
                input = Console.ReadLine();
            }
            PrintList(bankList);
        }

        private static void PrintList(List<BankAccount> bankList)
        {
            var sorted = bankList.OrderByDescending(b => b.Balance).ThenBy(b => b.Bank.Length).ToList();
            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Name} -> {item.Balance} ({item.Bank})");
            }
        }

        static BankAccount EnterNewAccount(string input)
        {
            List<string> curentInput = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            BankAccount result = new BankAccount {
                Name = curentInput[1],
                Bank=curentInput[0],
                Balance=decimal.Parse(curentInput[2])
            };
            return result;
        }

        class BankAccount
        {
            public string Name { get; set; }
            public string Bank { get; set; }
            public decimal Balance { get; set; }
        }
    }
}
