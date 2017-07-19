using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, KeyValuePair<string, int>> lambadaList = new Dictionary<string, KeyValuePair<string, int>>();
            string input = Console.ReadLine();
            while (input!= "lambada")
            {
                if (input== "dance")
                {
                    List<string> listOfKeys = lambadaList.Keys.ToList();
                    for (int i = 0; i < listOfKeys.Count; i++)
                    {
                        string theKey = lambadaList[listOfKeys[i]].Key;
                        int number = lambadaList[listOfKeys[i]].Value + 1;
                        lambadaList[listOfKeys[i]]=new KeyValuePair<string, int>(theKey,number );
                    }
                }
                else
                {
                    string[] curentInput = input.Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string aKey = curentInput[0];
                    string aValue = curentInput[1];
                    lambadaList[aKey] = new KeyValuePair<string, int>(aValue, 0);
                }
                input = Console.ReadLine();
            }
            var sorted = lambadaList.OrderByDescending(kvp => kvp.Value.Value);
            foreach (var item in sorted)
            {
                int turns = item.Value.Value;
                Console.Write($"{item.Key} => ");
                if (turns > 0)
                {
                    for (int i = 0; i < turns; i++)
                    {
                        Console.Write($"{item.Key}.");
                    }
                }
                Console.WriteLine(item.Value.Key);
            }
        }
    }
}
