using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Increasing_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool token = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != 0)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        token = false;
                        break;
                    }
                }
            }
            if (token)
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
