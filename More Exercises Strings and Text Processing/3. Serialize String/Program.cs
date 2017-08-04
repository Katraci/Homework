using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Serialize_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, List<int>> listOfLeters = new Dictionary<char, List<int>>();
            char[] input = Console.ReadLine().ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                char curent = input[i];
                if (!listOfLeters.ContainsKey(curent))
                {
                    listOfLeters[curent] = new List<int>();
                }
                listOfLeters[curent].Add(i);
            }
            foreach (var item in listOfLeters)
            {
                Console.WriteLine(item.Key+":"+string.Join("/",item.Value));
            }
        }
    }
}
