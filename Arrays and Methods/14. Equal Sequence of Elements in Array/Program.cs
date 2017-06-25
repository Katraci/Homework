using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Equal_Sequence_of_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int token = arr[0];
            bool equans = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]!=token)
                {
                    equans = false;
                    break;
                }
            }
            if (equans)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
