using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> myDict = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] curentInput = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (myDict.ContainsKey(curentInput[0]) && myDict.ContainsKey(curentInput[1]))
                {
                    foreach (var item in myDict[curentInput[1]])
                    {
                        myDict[curentInput[0]].Add(item);
                    }
                    
                }
                bool check = CheCkInput(curentInput[1]);
                if (check)
                {
                    if (!myDict.ContainsKey(curentInput[0]))
                    {
                        myDict[curentInput[0]] = new List<int>();
                    }
                    int[] arr = curentInput[1]
                        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    for (int i = 0; i < arr.Length; i++)
                    {

                        myDict[curentInput[0]].Add(arr[i]);
                    }
                }
                else
                {
                    if (myDict.ContainsKey(curentInput[1]) && !myDict.ContainsKey(curentInput[0]))
                    {
                        myDict[curentInput[0]] = new List<int>();
                        foreach (var item in myDict[curentInput[1]])
                        {
                            myDict[curentInput[0]].Add(item);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in myDict)
            {
                Console.Write($"{item.Key} === ");
                Console.WriteLine(string.Join(", ", item.Value));
            }
        }

        private static bool CheCkInput(string v)
        {
            string[] arr = v.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int forNoUse;
            bool result = int.TryParse(arr[0], out forNoUse);
            return result;
        }
    }
}
