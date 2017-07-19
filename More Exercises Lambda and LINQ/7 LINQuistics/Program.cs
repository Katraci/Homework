using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_LINQuistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> listMethods = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input!= "exit")
            {
                string[] curentInput = input.Split(new char[] { '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (curentInput.Length==1)
                {
                    int n;
                    if (int.TryParse(curentInput[0],out n))
                    {
                        if (listMethods.Count>0)
                        {
                            var mostMethod = listMethods.OrderByDescending(kvp => kvp.Value.Count).Take(1);

                            foreach (var item in mostMethod)
                            {
                                int token = 0;
                                foreach (var part in item.Value.OrderBy(w => w.Length))
                                {
                                    token++;
                                    Console.WriteLine($"* {part}");
                                    if (token == n)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    if (listMethods.ContainsKey(curentInput[0]))
                    {
                        foreach (var item in listMethods[curentInput[0]].OrderByDescending(w=>w.Length).ThenByDescending(method => method.Distinct().Count()))
                        {
                            Console.WriteLine($"* {item}");
                        }
                    }
                }
                else
                {
                    string name = curentInput[0];
                    if (!listMethods.ContainsKey(name))
                    {
                        listMethods[name] = new List<string>();
                    }
                    for (int i = 1; i < curentInput.Length; i++)
                    {
                        if (!listMethods[name].Contains(curentInput[i]))
                        {
                            listMethods[name].Add(curentInput[i]);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            string[] command = Console.ReadLine().Split(' ').ToArray();
            var sorted = listMethods.OrderByDescending(kvp => kvp.Value.Count).ThenByDescending(d => d.Value.OrderBy(m => m.Length).First().Length);
            foreach (var item in sorted)
            {
                if (item.Value.Contains(command[0]))
                {
                    Console.WriteLine(item.Key);
                    if (command[1] == "all")
                    {
                        var sortedValue = item.Value.OrderByDescending(w => w.Length).ToList();
                        foreach (var part in sortedValue)
                        {
                            Console.WriteLine($"* {part}");
                        }

                    }
                }
            }
        }
    }
}
