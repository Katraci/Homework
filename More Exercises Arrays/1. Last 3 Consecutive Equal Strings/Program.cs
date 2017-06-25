using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Last_3_Consecutive_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            string triple = "";
            for (int i = 0; i < arr.Length-2; i++)
            {
                if (arr[i]==arr[i+1]&&arr[i]==arr[i+2])
                {
                    triple = arr[i];
                }
            }
            Console.WriteLine("{0} {0} {0}", triple);
        }
    }
}
