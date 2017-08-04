using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Deserialize_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> listOfLeters = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] curent = input.Split(':');
                string token = curent[0];
                listOfLeters[token] = curent[1].Split('/').Select(int.Parse).ToList();
                input = Console.ReadLine();
            }
            int lenght = listOfLeters.Sum(v => v.Value.Count);
            string[] result = new string[lenght];
            foreach (var item in listOfLeters)
            {
                string token = item.Key;
                foreach (var num in item.Value)
                {
                    result[num] = token;
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
