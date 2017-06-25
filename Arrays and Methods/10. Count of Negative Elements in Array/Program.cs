using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Count_of_Negative_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLeght = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLeght];
            int counter = 0;
            for (int i = 0; i < arrLeght; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i]<0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
