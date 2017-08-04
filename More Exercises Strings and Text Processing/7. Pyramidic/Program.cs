using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Pyramidic
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> listInputs = new List<string>();
            Dictionary<char, int> listOfPyramid = new Dictionary<char, int>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                listInputs.Add(Console.ReadLine());
            }
            for (int i = 0; i < listInputs.Count; i++)
            {
                string input = listInputs[i];
                if (i == 0)
                {
                    FullTheDictinary(listOfPyramid, input);
                }
                else
                {
                    string previos= listInputs[i-1];
                    List<char> helping = new List<char>();
                    foreach (var item in listOfPyramid)
                    {
                        string counter = new string(item.Key, item.Value + 2);
                        string seconCounter = new string(item.Key, item.Value);
                        if (input.Contains(counter)&&previos.Contains(seconCounter))
                        {
                            helping.Add(item.Key);
                        }
                    }
                    string left = "";
                    for (int j = 0;j < helping.Count; j++)
                    {
                        char item = helping[j];
                        string counter = new string(item, listOfPyramid[item] + 2);
                        int index = input.IndexOf(counter);
                        left = input.Remove(index, counter.Length);
                        listOfPyramid[item] += 2;
                    }
                    FullTheDictinary(listOfPyramid, left);
                }
            }
            KeyValuePair<char, int> result = listOfPyramid.OrderByDescending(n => n.Value).First();
            for (int i = 1; i <= result.Value; i += 2)
            {
                string line = new string(result.Key, i);
                Console.WriteLine(line);
            }

        }

        private static void FullTheDictinary(Dictionary<char, int> listOfPyramid, string input)
        {
            char[] token = input.ToCharArray();
            for (int i = 0; i < token.Length; i++)
            {
                if (!listOfPyramid.ContainsKey(token[i]))
                {
                    listOfPyramid[token[i]] = 1;
                }
            }
        }
    }
}
