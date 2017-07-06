using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> myDictionary = new SortedDictionary<string, long>();
            string input = "";
            while (input!= "Over")
            {
                input = Console.ReadLine();
                if (input != "Over")
                {
                    string[] arr = input.Split(' ').ToArray();
                    long number = 0;
                    bool check = long.TryParse(arr[0], out number);
                    if (check)
                    {
                        myDictionary[arr[2]] = number;
                    }
                    else
                    {
                        myDictionary[arr[0]] = long.Parse(arr[2]);
                    }
                }
            }
            foreach (KeyValuePair<string,long> item in myDictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
