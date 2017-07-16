using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Flatten_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> pairs = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, List<string>> flatten = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input!="end")
            {

                string[] curentInput = input.Split(' ');
                if (curentInput[0] != "flatten")
                {
                    if (!pairs.ContainsKey(curentInput[0]))
                    {
                        pairs[curentInput[0]] = new Dictionary<string, string>();
                    }
                    if (curentInput.Length > 2)
                    {
                        pairs[curentInput[0]][curentInput[1]] = curentInput[2];
                    }
                }
                else
                {
                    string[] lastKeys = pairs[curentInput[1]].Keys.Reverse().Take(2).ToArray();
                    string[] lastValue = pairs[curentInput[1]].Values.Reverse().Take(2).ToArray();
                    pairs[curentInput[1]].Remove(lastKeys[0]);
                    pairs[curentInput[1]].Remove(lastKeys[1]);
                    if (!flatten.ContainsKey(curentInput[1]))
                    {
                        flatten[curentInput[1]] = new List<string>();
                    }
                    flatten[curentInput[1]].Add(lastKeys[1] + lastValue[1]);
                    flatten[curentInput[1]].Add(lastKeys[0] + lastValue[0]);

                }
                input = Console.ReadLine();
            }
            var sorted = pairs.OrderByDescending(kvp => kvp.Key.Length);
            foreach (var item in sorted)
            {
                var inerPair = item.Value.OrderBy(kvp => kvp.Key.Length);
                Console.WriteLine(item.Key);
                    int posicion = 0;
                foreach (var part in inerPair)
                {

                        posicion++;
                        Console.WriteLine($"{posicion}. {part.Key} - {part.Value}");

                }
                if (flatten.ContainsKey(item.Key))
                {
                    foreach (var part in flatten)
                    {
                        foreach (var piece in flatten.Values)
                        {
                            posicion++;
                            Console.WriteLine($"{posicion}. {piece}");
                        }
                       


                    }
                }

            }
        }
    }
}
