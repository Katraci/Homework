using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Array_Elements_Equal_to_Their_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string equalToIndex = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (i!=arr.Length-1)
                {
                    if (i==arr[i])
                    {
                        equalToIndex += arr[i].ToString() + " ";
                    }
                }
                else
                {
                    if(i == arr[i])
                    {
                        equalToIndex += arr[i].ToString();
                    }
                }
            }
            Console.WriteLine(equalToIndex);
        }
    }
}
