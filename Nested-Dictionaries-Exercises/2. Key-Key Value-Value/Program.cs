using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Key_Key_Value_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyInput = Console.ReadLine();
            string valueInput = Console.ReadLine();
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> pairs = new Dictionary<string, List<string>>();
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string curentKey = input[0];
                string curentValue = input[1];
                if (curentKey.Contains(keyInput))
                {
                    if (!pairs.ContainsKey(curentKey))
                    {
                        pairs[curentKey] = new List<string>();
                    }
                    string[] tokenValue = curentValue.Split(';').ToArray();
                    foreach (string value in tokenValue)
                    {
                        if (value.Contains(valueInput))
                        {
                            pairs[curentKey].Add(value);
                        }
                    }
                }
            }
            foreach (var item in pairs)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (string token in item.Value)
                {
                    Console.WriteLine($"-{token}");
                }
            }
        }
    }
}
