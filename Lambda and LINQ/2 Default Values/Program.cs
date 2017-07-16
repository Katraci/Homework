using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Default_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            Dictionary<string, string> nullWords = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] arr = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (words.ContainsKey(arr[0]))
                {
                    words.Remove(arr[0]);
                }
                if(nullWords.ContainsKey(arr[0]))
                {
                    nullWords.Remove(arr[0]);
                }
                if (arr[1]=="null")
                {
                    nullWords[arr[0]] = arr[1];
                }
                else
                {
                    words[arr[0]] = arr[1];
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            var sorted = words.OrderByDescending(kvp => kvp.Value.Length).Concat(nullWords);
            foreach (var item in sorted)
            {
                if (item.Value!="null")
                {
                    Console.WriteLine($"{item.Key} <-> {item.Value}");
                }
                else
                {
                    Console.WriteLine($"{item.Key} <-> {input}");
                }
            }
        }
    }
}
