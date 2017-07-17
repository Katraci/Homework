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
                if (curentInput[0] == "flatten")
                {
                    foreach (var item in pairs)
                    {
                        if (item.Key == curentInput[1])
                        {
                            foreach (var piece in item.Value)
                            {
                                if (!flatten.ContainsKey(curentInput[1]))
                                {
                                    flatten[curentInput[1]] = new List<string>();
                                }
                                flatten[curentInput[1]].Add(piece.Key + piece.Value);
                            }
                        }
                    }
                    pairs[curentInput[1]]= new Dictionary<string, string>();
                }
                else
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
                   
                        foreach (var piece in flatten[item.Key])
                        {
                            posicion++;
                            Console.WriteLine($"{posicion}. {piece}");
                        }
                }

            }
        }
    }
}
