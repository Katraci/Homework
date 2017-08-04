using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] curentInput = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string result = curentInput[0];
                string[] change = curentInput[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < change.Length; i++)
                {
                    string wordToChange = "{" + i.ToString() + "}";
                    result = result.Replace(wordToChange, change[i]);
                }
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}
