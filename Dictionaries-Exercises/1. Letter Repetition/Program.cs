using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Letter_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characterCounter = new Dictionary<char, int>();
            List<char> input = Console.ReadLine().ToList();
            for (int i = 0; i < input.Count; i++)
            {
                if (!characterCounter.ContainsKey(input[i]))
                {
                    characterCounter.Add(input[i], 1);
                }
                else
                {
                    characterCounter[input[i]]++;
                }
            }
            foreach (KeyValuePair<char,int> item in characterCounter)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
