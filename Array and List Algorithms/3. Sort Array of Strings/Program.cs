using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            while (true)
            {
                bool check = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i].CompareTo(arr[i+1])>0)
                    {
                        string helping = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = helping;
                        check = true;
                    }
                }
                if (!check)
                {
                    break;
                }

            }
           
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
