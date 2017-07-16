using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Registered_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, DateTime> users = new Dictionary<string, DateTime>();
            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] curentUser = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string userName = curentUser[0];
                DateTime registerDate = DateTime.ParseExact(curentUser[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                users[userName] = registerDate;
                input = Console.ReadLine();
            }
            List<string> sortedUsers = users.OrderByDescending(kvp => kvp.Value)
                .Reverse()
                .Take(5)
                .OrderByDescending(kvp => kvp.Value)
                .Select(kvp => kvp.Key)
                .ToList();
            Console.WriteLine(string.Join("\n", sortedUsers));
        }
    }
}
