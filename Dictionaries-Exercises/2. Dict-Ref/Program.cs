using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            string input ="";
            while (input!="end")
            {
                input= Console.ReadLine();
                if (input!="end")
                {
                    string[] arr = input.Split(' ').ToArray();
                    int number;
                    bool chek = int.TryParse(arr[arr.Length - 1],out number);
                    if (!myDictionary.ContainsKey(arr[0]))
                    {

                        if (myDictionary.ContainsKey(arr[arr.Length - 1]))
                        {
                            myDictionary[arr[0]] = myDictionary[arr[arr.Length - 1]];
                        }
                        else
                        {
                            if(chek)
                            myDictionary[arr[0]] = number;
                        }

                    }
                    else
                    {
                        if (myDictionary.ContainsKey(arr[arr.Length - 1]))
                        {
                            myDictionary[arr[0]] = myDictionary[arr[arr.Length - 1]];
                        }
                        else
                        {
                            if (chek)
                                myDictionary[arr[0]] = number;
                        }
                    }
                }
            }
            foreach (KeyValuePair<string,int> item in myDictionary)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}
